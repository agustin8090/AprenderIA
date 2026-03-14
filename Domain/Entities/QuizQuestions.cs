using System;

namespace MentorIA.Domain.Entities;

public class QuizQuestions
{
public Guid Id { get; set; }
public Guid PracticeQuizId { get; set; }
public PracticeQuiz PracticeQuiz { get; set; }= null!;
public string QuestionText { get; set; } = string.Empty;
public string OptionA { get; set; } = string.Empty;
public string OptionB { get; set; } = string.Empty;
public string OptionC { get; set; } = string.Empty;
public string OptionD { get; set; } = string.Empty;
public string CorrectOption { get; set; } = string.Empty;


}
