using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork {
    public class QuizDataAccess {
        private string connectionString;

        public QuizDataAccess(string connectionString) {
            this.connectionString = connectionString;
        }
        public List<Question> LoadQuestionsFromDatabase() {
            var questions = new List<Question>();
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                string query = "SELECT QuestionId, QuestionText, QuestionType, CorrectAnswer, AnswerOptions FROM Questions";
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        int questionId = Convert.ToInt32(reader["QuestionId"]);
                        string questionText = reader["QuestionText"]?.ToString() ?? string.Empty;
                        string questionType = reader["QuestionType"]?.ToString() ?? string.Empty;
                        string correctAnswer = reader["CorrectAnswer"]?.ToString() ?? string.Empty;
                        string answerOptions = reader["AnswerOptions"]?.ToString() ?? string.Empty;

                        if (questionType == "MultipleChoice") {
                            var mcq = new MultipleChoiceQuestion(questionText) {
                                QuestionId = questionId,
                                Options = answerOptions.Split(','),
                                CorrectIndex = Array.IndexOf(answerOptions.Split(','), correctAnswer)
                            };
                            questions.Add(mcq);
                        } else if (questionType == "OpenEnded") {
                            var oq = new OpenEndedQuestion(questionText) {
                                QuestionId = questionId,
                                AcceptableAnswers = answerOptions.Split(',').Select(s => s.Trim()).ToList()
                            };
                            questions.Add(oq);
                        } else if (questionType == "TrueFalse") {
                            var tfq = new TrueFalseQuestion(questionText) {
                                QuestionId = questionId,
                                IsTrue = correctAnswer.Equals("True", StringComparison.OrdinalIgnoreCase)
                            };
                            questions.Add(tfq);
                        }
                    }
                }
            }
            return questions;
        }

        public void SaveQuestionToDatabase(Question question) {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    string query = "INSERT INTO Questions (QuestionText, QuestionType, CorrectAnswer, AnswerOptions) " +
                                   "VALUES (@QuestionText, @QuestionType, @CorrectAnswer, @AnswerOptions)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@QuestionText", question.QuestionText);
                    cmd.Parameters.AddWithValue("@QuestionType", question.Type.ToString());

                    if (question is MultipleChoiceQuestion mcq) {
                        cmd.Parameters.AddWithValue("@CorrectAnswer", mcq.Options[mcq.CorrectIndex]);
                        cmd.Parameters.AddWithValue("@AnswerOptions", string.Join(",", mcq.Options));

                    } else if (question is OpenEndedQuestion oq) {
                        cmd.Parameters.AddWithValue("@CorrectAnswer", string.Join(",", oq.AcceptableAnswers));
                        cmd.Parameters.AddWithValue("@AnswerOptions", string.Join(",", oq.AcceptableAnswers));
                    } else if (question is TrueFalseQuestion tfq) {
                        cmd.Parameters.AddWithValue("@CorrectAnswer", tfq.IsTrue ? "True" : "False");
                        cmd.Parameters.AddWithValue("@AnswerOptions", "True,False");
                    }
                    cmd.ExecuteNonQuery();
                }
            } catch (Exception e) {
                MessageBox.Show($"Error saving question to database: {e.Message}");
            }
        }

        public void UpdateQuestionInDatabase(Question question) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                string query = "UPDATE Questions SET QuestionText = @QuestionText, CorrectAnswer = @CorrectAnswer, AnswerOptions = @AnswerOptions WHERE QuestionId = @QuestionId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@QuestionId", question.QuestionId);
                cmd.Parameters.AddWithValue("@QuestionText", question.QuestionText);

                if (question is MultipleChoiceQuestion mcq) {
                    cmd.Parameters.AddWithValue("@CorrectAnswer", mcq.Options[mcq.CorrectIndex]);
                    cmd.Parameters.AddWithValue("@AnswerOptions", string.Join(",", mcq.Options));
                } else if (question is OpenEndedQuestion oq) {
                    cmd.Parameters.AddWithValue("@CorrectAnswer", string.Join(",", oq.AcceptableAnswers));
                    cmd.Parameters.AddWithValue("@AnswerOptions", string.Join(",", oq.AcceptableAnswers));
                } else if (question is TrueFalseQuestion tfq) {
                    cmd.Parameters.AddWithValue("@CorrectAnswer", tfq.IsTrue ? "True" : "False");
                    cmd.Parameters.AddWithValue("@AnswerOptions", string.Empty);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteQuestionFromDatabase(Question question) {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Open();
                string query = "DELETE FROM Questions WHERE QuestionId = @QuestionId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@QuestionId", question.QuestionId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
