using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork {
    public class OpenEndedQuestion : Question {
        public OpenEndedQuestion(string questionText) : base(questionText) {
            Type = QuestionType.OpenEnded;
        }

        public List<string> AcceptableAnswers { get; set; }

        public override bool checkAnswer(string userAnswer) {
            return AcceptableAnswers
                .Any(ans => ans.Trim().Equals(userAnswer.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public override string getCorrectAnswer() => string.Join(" / ", AcceptableAnswers);

       
    }
}
