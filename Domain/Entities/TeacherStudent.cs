using System;
using AprenderIA.Domain.Entities;

namespace AprenderIA.Domain.Entities;

public class TeacherStudent
{

public Guid TeacherId { get; set; }
public Guid StudentId { get; set; }

public DateTime LinkedAt { get; set; }=DateTime.UtcNow;

public bool IsActive { get; set; }  =true;
}
