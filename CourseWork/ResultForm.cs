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
    public partial class ResultForm : Form {
        public ResultForm(List<(Question question, string userAnswer)> userAnswers) {
            InitializeComponent();
            dataGridViewSummary.Columns.Add("Question", "Question");
            dataGridViewSummary.Columns.Add("YourAnswer", "Your Answer");
            dataGridViewSummary.Columns.Add("CorrectAnswer", "Correct Answer");
            dataGridViewSummary.Columns.Add("Result", "Result");

            foreach (var (question, userAnswer) in userAnswers) {
                string correctAnswer = question.getCorrectAnswer();
                string result = string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase) ? "Correct" : "Incorrect";
                dataGridViewSummary.Rows.Add(question.QuestionText, userAnswer, correctAnswer, result);
            }
        }
    }
}
