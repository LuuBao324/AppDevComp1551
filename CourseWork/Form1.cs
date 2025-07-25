namespace CourseWork
{
    public partial class Form1 : Form {

        private QuizManager quizManager;
        private string connectionString = "Data Source=LAPTOP-07\\SQLEXPRESS;Integrated Security=True; Initial Catalog=CourseWork;" +
                                           "Trusted_Connection=True; Trust Server Certificate=True;" +
                                            "User Id=admin, Password= ";

        public Form1(QuizManager quizM) {
            InitializeComponent();

            quizManager = quizM;

        }

        private void createQuizBtn_Click(object sender, EventArgs e) {

            var CreateQuizForm = new CreateQuiz(quizManager);
            CreateQuizForm.ShowDialog();
        }

        private void playGameBtn_Click(object sender, EventArgs e) {
            
            var dataAccess = new QuizDataAccess(connectionString);
            quizManager.questionList.Clear();
            quizManager.questionList.AddRange(dataAccess.LoadQuestionsFromDatabase());

            var PlayQuizForm = new PlayQuiz(quizManager);
            
            if (quizManager.questionList.Count == 0) {
                MessageBox.Show("Please create a quiz first.", "Information",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            PlayQuizForm.ShowDialog();

        }
    }
}
