using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork {

    public partial class ManageQuiz : Form {

        
        private QuizManager quizManager;
        private string connectionString = "Data Source=LAPTOP-07\\SQLEXPRESS;Integrated Security=True; Initial Catalog=CourseWork;" + 
                                           "Trusted_Connection=True; Trust Server Certificate=True;" + 
                                            "User Id=admin, Password= ";
        private QuizDataAccess dataAccess;
        public ManageQuiz(QuizManager quizM) {
            InitializeComponent();

            quizManager = quizM;
            dataAccess = new QuizDataAccess(connectionString);

            textBoxQuestion.Text = "Enter a question";
            textBoxQuestion.ForeColor = Color.Gray;

            textBoxQuestion.GotFocus += (s, e) => {
                if (textBoxQuestion.Text == "Enter a question") {
                    textBoxQuestion.Text = "";
                    textBoxQuestion.ForeColor = Color.Black;
                }
            };

            textBoxQuestion.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBoxQuestion.Text)) {
                    textBoxQuestion.Text = "Enter a question";
                    textBoxQuestion.ForeColor = Color.Gray;
                }
            };
            textBoxOpenEnded.Text = "e.g. UK, United Kingdom";
            textBoxOpenEnded.ForeColor = Color.Gray;

            textBoxOpenEnded.GotFocus += (s, e) => {
                if (textBoxOpenEnded.Text == "e.g. UK, United Kingdom") {
                    textBoxOpenEnded.Text = "";
                    textBoxOpenEnded.ForeColor = Color.Black;
                }
            };

            textBoxOpenEnded.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBoxOpenEnded.Text)) {
                    textBoxOpenEnded.Text = "e.g. UK, United Kingdom";
                    textBoxOpenEnded.ForeColor = Color.Gray;
                }
            };

            cbBoxQuesionType.Items.AddRange(new string[] {
                                "Multiple Choice",
                                "Open Ended",
                                "True/False"
                            });

            cbBoxQuesionType.SelectedIndex = 0;
            multipleChoicePanel.Location = openEndedPanel.Location = trueFalsePanel.Location = new Point(87, 245);
            multipleChoicePanel.Visible = true;
            openEndedPanel.Visible = false;
            trueFalsePanel.Visible = false;
            cbBoxQuesionType.SelectedIndexChanged += (s, e) => {
                switch (cbBoxQuesionType.SelectedIndex) {
                    case 0:
                        multipleChoicePanel.Visible = true;
                        openEndedPanel.Visible = false;
                        trueFalsePanel.Visible = false;
                        break;
                    case 1:
                        openEndedPanel.Visible = true;
                        multipleChoicePanel.Visible = false;
                        trueFalsePanel.Visible = false;
                        break;
                    case 2:
                        trueFalsePanel.Visible = true;
                        multipleChoicePanel.Visible = false;
                        openEndedPanel.Visible = false;
                        break;
                }

            };

            listBoxQuestion.SelectedIndexChanged += (s, e) => {
                if (listBoxQuestion.SelectedItem is Question selectedQuestion) {
                    textBoxQuestion.Text = selectedQuestion.QuestionText;
                    textBoxQuestion.ForeColor = Color.Black;
                    buttonUpdate.Enabled = true;
                    buttonCreate.Enabled = false;
                    cbBoxQuesionType.SelectedItem = selectedQuestion.Type.ToString();
                    switch (selectedQuestion.Type) {
                        case QuestionType.MultipleChoice:
                            var mcq = (MultipleChoiceQuestion)selectedQuestion;
                            cbBoxQuesionType.SelectedItem = "Multiple Choice";
                            textBoxCorrectAns.Text = mcq.Options[0];
                            textBoxOption1.Text = mcq.Options[1];
                            textBoxOption2.Text = mcq.Options[2];
                            textBoxOption3.Text = mcq.Options[3];
                            break;
                        case QuestionType.OpenEnded:
                            var oq = (OpenEndedQuestion)selectedQuestion;
                            cbBoxQuesionType.SelectedItem = "Open Ended";
                            textBoxOpenEnded.Text = string.Join(", ", oq.AcceptableAnswers);
                            break;
                        case QuestionType.TrueFalse:
                            var tfq = (TrueFalseQuestion)selectedQuestion;
                            cbBoxQuesionType.SelectedItem = "True/False";
                            radioButtonTrue.Checked = tfq.IsTrue;
                            radioButtonFalse.Checked = !tfq.IsTrue;
                            break;
                    }
                }
            };


            refreshList();
        }

        private void refreshList() {
            listBoxQuestion.Items.Clear();
            listBoxQuestion.Items.AddRange(quizManager.questionList.ToArray());
            var loadQuestions = dataAccess.LoadQuestionsFromDatabase();
            quizManager.questionList.Clear();
            quizManager.questionList.AddRange(loadQuestions);
            listBoxQuestion.Items.Clear();
            listBoxQuestion.Items.AddRange(quizManager.questionList.ToArray());
        }



        private void buttonCreate_Click(object sender, EventArgs e) {
            var text = textBoxQuestion.Text.Trim();
            if (string.IsNullOrWhiteSpace(text) || text == "Enter a question") {
                MessageBox.Show("Please enter a question.");
                return;
            }

            Question q = null;

            switch (cbBoxQuesionType.SelectedItem?.ToString()) {
                case "Multiple Choice":
                    string[] options = new string[4];
                    options[0] = textBoxCorrectAns.Text;
                    options[1] = textBoxOption1.Text;
                    options[2] = textBoxOption2.Text;
                    options[3] = textBoxOption3.Text;

                    if (string.IsNullOrWhiteSpace(options[0])) {
                        MessageBox.Show("Please enter a correct answer.");
                        return;
                    }

                    var mcq = new MultipleChoiceQuestion(text);
                    mcq.Options = options;
                    mcq.CorrectIndex = 0;

                    q = mcq;

                    break;
                case "Open Ended":
                    var answers = textBoxOpenEnded.Text
                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim()).ToList();
                    var oq = new OpenEndedQuestion(text);
                    oq.AcceptableAnswers = answers;
                    q = oq;
                    break;

                case "True/False":
                    var tfq = new TrueFalseQuestion(text);
                    tfq.IsTrue = radioButtonTrue.Checked;
                    q = tfq;
                    break;
            }

            if (q != null) {
                dataAccess.SaveQuestionToDatabase(q);
                quizManager.questionList.Add(q);
                refreshList();
                refreshInputFields();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            if (listBoxQuestion.SelectedItem is Question selectedQuestion) {
                var text = textBoxQuestion.Text.Trim();
                if (string.IsNullOrWhiteSpace(text)) {
                    MessageBox.Show("Please enter a question.");
                    return;
                }
                switch (cbBoxQuesionType.SelectedItem?.ToString()) {
                    case "Multiple Choice":
                        if (selectedQuestion is MultipleChoiceQuestion mcq) {
                            mcq.QuestionText = text;
                            mcq.Options[0] = textBoxCorrectAns.Text;
                            mcq.Options[1] = textBoxOption1.Text;
                            mcq.Options[2] = textBoxOption2.Text;
                            mcq.Options[3] = textBoxOption3.Text;
                        }
                        break;
                    case "Open Ended":
                        if (selectedQuestion is OpenEndedQuestion oq) {
                            oq.QuestionText = text;
                            oq.AcceptableAnswers = textBoxOpenEnded.Text
                                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => s.Trim()).ToList();
                        }
                        break;
                    case "True/False":
                        if (selectedQuestion is TrueFalseQuestion tfq) {
                            tfq.QuestionText = text;
                            tfq.IsTrue = radioButtonTrue.Checked;
                        }
                        break;
                }
                dataAccess.UpdateQuestionInDatabase(selectedQuestion);
                refreshList();
                refreshInputFields();
            } else {
                MessageBox.Show("Please select a question to update.");
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e) {
            if (listBoxQuestion.SelectedItem is Question selectedQuestion) {
                quizManager.questionList.Remove(selectedQuestion);
                dataAccess.DeleteQuestionFromDatabase(selectedQuestion);
                refreshList();
                refreshInputFields();
            } else {
                MessageBox.Show("Please select a question to delete.");
            }
        }

        private void refreshInputFields() {
            textBoxQuestion.Text = "Enter question text";
            textBoxQuestion.ForeColor = Color.Gray;
            textBoxOpenEnded.Text = "e.g. UK, United Kingdom";
            textBoxOpenEnded.ForeColor = Color.Gray;
            textBoxCorrectAns.Text = "";
            textBoxOption1.Text = "";
            textBoxOption2.Text = "";
            textBoxOption3.Text = "";
            radioButtonTrue.Checked = false;
            radioButtonFalse.Checked = false;

            textBoxQuestion.Text = "Enter a question";
            textBoxQuestion.ForeColor = Color.Gray;

            textBoxQuestion.GotFocus += (s, e) => {
                if (textBoxQuestion.Text == "Enter a question") {
                    textBoxQuestion.Text = "";
                    textBoxQuestion.ForeColor = Color.Black;
                }
            };

            textBoxQuestion.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBoxQuestion.Text)) {
                    textBoxQuestion.Text = "Enter a question";
                    textBoxQuestion.ForeColor = Color.Gray;
                }
            };
            textBoxOpenEnded.Text = "e.g. UK, United Kingdom";
            textBoxOpenEnded.ForeColor = Color.Gray;

            textBoxOpenEnded.GotFocus += (s, e) => {
                if (textBoxOpenEnded.Text == "e.g. UK, United Kingdom") {
                    textBoxOpenEnded.Text = "";
                    textBoxOpenEnded.ForeColor = Color.Black;
                }
            };

            textBoxOpenEnded.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBoxOpenEnded.Text)) {
                    textBoxOpenEnded.Text = "e.g. UK, United Kingdom";
                    textBoxOpenEnded.ForeColor = Color.Gray;
                }
            };

            buttonCreate.Enabled = true;
            buttonUpdate.Enabled = false;
        }

        private void CreateQuiz_Load(object sender, EventArgs e) {
            refreshList();
        }
    }
}

