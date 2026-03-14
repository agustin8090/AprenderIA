using static AprenderIA.Domain.Entities.Enums;

namespace AprenderIA.Domain.Entities;

public class User
{

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public UserRole Role { get; set; }

    public string PasswordHash{ get; set; } = string.Empty;


}
