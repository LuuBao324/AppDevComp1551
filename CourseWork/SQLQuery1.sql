﻿
use CourseWorkDB;
CREATE TABLE Questions (
    QuestionId INT IDENTITY(1,1) PRIMARY KEY,
    QuestionText NVARCHAR(255) NOT NULL,
    QuestionType NVARCHAR(50) NOT NULL,
    CorrectAnswer NVARCHAR(255) NOT NULL,
    AnswerOptions NVARCHAR(255),
);