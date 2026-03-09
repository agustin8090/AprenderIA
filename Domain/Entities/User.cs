using static AprenderIA.Domain.Entities.Enum;

namespace AprenderIA.Domain.Entities;

public class User
{

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public UserRole Role { get; set; }

    public string Password{ get; set; } = string.Empty;


}
