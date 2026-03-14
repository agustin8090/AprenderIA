using System;

namespace MentorIA.Domain.Entities;

public class MaterialSummary
{
public Guid Id { get; set; }
public Guid MaterialId { get; set; }
public Material Material { get; set; }= null!;
public string SummaryText { get; set; } = string.Empty;
public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


}
