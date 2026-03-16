
using System;
using static AprenderIA.Domain.Enums.Enums;


namespace AprenderIA.Domain.Entities;

public class User
{

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public UserRole Role { get; set; }


 public ICollection<Material> Materials { get; set; } = [];
    public ICollection<TeacherStudent> TeacherLinks { get; set; } = [];
    public ICollection<TeacherStudent> StudentLinks { get; set; } = [];

}
