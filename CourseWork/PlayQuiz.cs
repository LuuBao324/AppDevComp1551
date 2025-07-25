using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork {
    public partial class PlayQuiz : Form {

        private QuizManager quizManager;
        private System.Windows.Forms.Timer questionTimer;
        private int timeLeft;

        public PlayQuiz(QuizManager quizM) {
            InitializeComponent();
            quizManager = quizM;

            panelMultiAnswer.Location = panelOpAnswer.Location = panelTFAnswer.Location = new Point(89, 108);
            questionTimer = new System.Windows.Forms.Timer(); 
            questionTimer.Interval = 1000;
            questionTimer.Tick += questionTimer_Tick_Tick; 

            quizManager.StartQuiz();
            LoadCurrentQuestion();
        }



        private void LoadCurrentQuestion() {
            Question currentQuestion = quizManager.GetCurrentQuestion();

            if (currentQuestion == null) {
                EndGame();
                return;
            }

            labelQuestionText.Text = currentQuestion.QuestionText;
            panelMultiAnswer.Visible = false;
            panelOpAnswer.Visible = false;
            panelTFAnswer.Visible = false;

            if (currentQuestion is MultipleChoiceQuestion multiQuestion) {
                panelMultiAnswer.Visible = true;

                var options = multiQuestion.Options;
                var indices = Enumerable.Range(0, options.Length).ToArray();
                var random = new Random();
                indices = indices.OrderBy(x => random.Next()).ToArray();
                Button[] buttons = { button1, button2, button3, button4 };
                for (int i = 0; i < indices.Length; i++) {
                    buttons[i].Text = options[indices[i]];
                    buttons[i].Tag = indices[i];

                }
            } else if (currentQuestion is TrueFalseQuestion tfQuestion) {
                panelTFAnswer.Visible = true;
                radioButton1.Text = "True";
                radioButton2.Text = "False";
                radioButton1.Checked = radioButton2.Checked = false;
            } else if (currentQuestion is OpenEndedQuestion opQuestion) {
                panelOpAnswer.Visible = true;
                textBoxAnswer.Text = string.Empty;
            }

            timeLeft = 15;
            labelClock.Text = $"00:{timeLeft.ToString("00")}";
            questionTimer.Start();
        }




        private void checkAnswerEvent(object sender, EventArgs e) {
            Question currentQuestion = quizManager.GetCurrentQuestion();

            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (currentQuestion is MultipleChoiceQuestion multiQuestion) {
                string selectedAnswer = multiQuestion.Options[buttonTag];
                quizManager.SubmitAnswer(selectedAnswer);
                questionTimer.Stop();
                LoadCurrentQuestion();
            }
        }

        private void questionTimer_Tick_Tick(object sender, EventArgs e) {
            timeLeft--;
            labelClock.Text = $"00:{timeLeft.ToString("00")}";
            if (timeLeft <= 0) {
                questionTimer.Stop();
                MessageBox.Show("Time's up!");
                quizManager.SubmitAnswer(""); 
                LoadCurrentQuestion();
            }
        }
        private void submitTFbtn_Click(object sender, EventArgs e) {
            Question currentQuestion = quizManager.GetCurrentQuestion();

            if (currentQuestion is TrueFalseQuestion tfQuestion) {
                string selectedAnswer = radioButton1.Checked ? "True" : "False";


                quizManager.SubmitAnswer(selectedAnswer);
                questionTimer.Stop();

                LoadCurrentQuestion();

            }
        }

        private void submitOPBtn_Click(object sender, EventArgs e) {
            Question currentQuestion = quizManager.GetCurrentQuestion();
            if (currentQuestion is OpenEndedQuestion opQuestion) {
                string userAnswer = textBoxAnswer.Text.Trim();


                quizManager.SubmitAnswer(userAnswer);

                questionTimer.Stop();
                LoadCurrentQuestion();
            }
        }

        private void EndGame() {
            var timeTaken = DateTime.Now - quizManager.startTime;
            int minutes = timeTaken.Minutes + timeTaken.Hours * 60;
            int seconds = timeTaken.Seconds;
            string formattedTime = $"{minutes:D2}:{seconds:D2}";
            MessageBox.Show($"Quiz completed! \n Your score: {quizManager.score} \n Time to finish: {formattedTime}");

            var summaryForm = new ResultForm(quizManager.UserAnswers);
            summaryForm.ShowDialog();
            this.Close();
        }

    }
}
