using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork {
    public class QuizManager {
        
        public List<Question> questionList { get; } = new List<Question>();
        public List<(Question question, string userAnswer)> UserAnswers { get; } = new();
        public int score { get; private set; }
        public DateTime startTime;
        private int currentQuestionIndex;

        public void StartQuiz() {
            startTime = DateTime.Now;
            score = 0;
            currentQuestionIndex = 0;
        }

        public Question GetCurrentQuestion() {
            if (currentQuestionIndex < questionList.Count)
                return questionList[currentQuestionIndex];
            return null;
        }

        public bool SubmitAnswer(string userAnswer, string displayAnswer = null) {
            var question = GetCurrentQuestion();
            UserAnswers.Add((question, displayAnswer ?? userAnswer));
            if (question == null) return false;
            bool correct = question.checkAnswer(userAnswer);
            if (correct) score++;
            currentQuestionIndex++;
            return correct;
        }
    }
}
