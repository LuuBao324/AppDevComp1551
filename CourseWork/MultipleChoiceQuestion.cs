using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork {
    public class MultipleChoiceQuestion : Question {
        public MultipleChoiceQuestion(string questionText) : base(questionText) {
            Type = QuestionType.MultipleChoice;
        }
        public string[] Options { get; set; } = new string[4];
        public int CorrectIndex { get; set; }

        public override bool checkAnswer(string userAnswer) {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            string answer = userAnswer.Trim().ToUpper();

            switch (answer) {
                case "A": return CorrectIndex == 0;
                case "B": return CorrectIndex == 1;
                case "C": return CorrectIndex == 2;
                case "D": return CorrectIndex == 3;
                default: return false;
            }
        }

        public override string getCorrectAnswer() {
            return Options[CorrectIndex];
        }
    }
}
