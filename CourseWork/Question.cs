using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public enum QuestionType 
        {
        MultipleChoice,
        OpenEnded,
        TrueFalse
    }
    public abstract class Question {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; } 
        public QuestionType Type { get; set; }

        public abstract bool checkAnswer(string userAnswer); 
        public abstract string getCorrectAnswer();

        public Question(string questionText) {
            this.QuestionText = questionText;
        }

        public override string ToString() {
            return $"({Type}) - {QuestionText} ";
        }
    }
}
