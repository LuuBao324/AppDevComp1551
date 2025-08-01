namespace CourseWork
{
    public partial class MainForm : Form {

        private QuizManager quizManager;
        private string connectionString = "Data Source=LAPTOP-07\\SQLEXPRESS;Integrated Security=True; Initial Catalog=CourseWork;" +
                                           "Trusted_Connection=True; Trust Server Certificate=True;" +
                                            "User Id=admin, Password= ";

        public MainForm(QuizManager quizM) {
            InitializeComponent();
            quizManager = quizM;
        }

        private void createQuizBtn_Click(object sender, EventArgs e) {

            var CreateQuizForm = new ManageQuiz(quizManager);
            CreateQuizForm.ShowDialog();
        }

        private void playGameBtn_Click(object sender, EventArgs e) {

            bool playAgain = true;
            while (playAgain) {
                var dataAccess = new QuizDataAccess(connectionString);
                quizManager.questionList.Clear();
                quizManager.questionList.AddRange(dataAccess.LoadQuestionsFromDatabase());

                var PlayQuizForm = new PlayQuiz(quizManager);

                if (quizManager.questionList.Count == 0) {
                    MessageBox.Show("Please create a quiz first.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                PlayQuizForm.ShowDialog();

                // After the quiz ends
                var resultForm = new ResultForm(quizManager.UserAnswers);
                var dialogResult = resultForm.ShowDialog();

                playAgain = resultForm.playAgain;
                quizManager.UserAnswers.Clear();
                quizManager.StartQuiz();
            }
        }
    }
}
