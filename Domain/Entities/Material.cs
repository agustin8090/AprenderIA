using System;
using AprenderIA.Domain.Entities;

namespace AprenderIA.Domain.Entities;

public class Material
{
public Guid Id { get; set; }
public Guid TeacherId { get; set; }
public User Teacher { get; set; }= null!;
public string Title { get; set; } = string.Empty;
public string Description { get; set; } = string.Empty;
public string FileUrl { get; set; } = string.Empty;
public string FileName { get; set; } = string.Empty;
public string contentType { get; set; } = string.Empty;
public DateTime UploadedAt { get; set; } = DateTime.UtcNow;


}
