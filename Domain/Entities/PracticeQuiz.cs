using System;
using AprenderIA.Domain.Entities;


namespace AprenderIA.Domain.Entities;

public class PracticeQuiz
{
public Guid Id { get; set; }
public Guid MaterialId { get; set; }
public Material Material { get; set; }= null!;  
public string Title { get; set; } = string.Empty;
public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

public List<QuizQuestions> Questions { get; set; } = new List<QuizQuestions>();

}
