using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork {
    public class TrueFalseQuestion : Question {

        public TrueFalseQuestion(string questionText) : base(questionText) {
            Type = QuestionType.TrueFalse;
        }

        public bool IsTrue { get; set; }

        public override bool checkAnswer(string userAnswer) {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            var trimmed = userAnswer.Trim().ToLowerInvariant();
            bool selected = (trimmed == "true" || trimmed == "t");
            return selected == IsTrue;
        }

        public override string getCorrectAnswer() {
            return IsTrue ? "True" : "False";
        }
    }
}
