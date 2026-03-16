using System;
using AprenderIA.Domain.Entities;

namespace AprenderIA.Domain.Entities;

public class Material
{
public Guid Id { get; set; }
public Guid TeacherId { get; set; }
public string Title { get; set; } = string.Empty;
public string Description { get; set; } = string.Empty;
public string FileUrl { get; set; } = string.Empty;
public string FileName { get; set; } = string.Empty;
public string contentType { get; set; } = string.Empty;
public MaterialSummary? Summary { get; set; }
public ICollection<PracticeQuiz> PracticeQuizzes { get; set; } = [];
public DateTime UploadedAt { get; set; } = DateTime.UtcNow;


}
