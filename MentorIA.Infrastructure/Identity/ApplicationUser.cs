using System;
using Microsoft.AspNetCore.Identity;
using static AprenderIA.Domain.Enums.Enums;

namespace AprenderIA.Infrastructure.Identity;

public class ApplicationUser: IdentityUser<Guid>
{

    public string Name { get; set; } = string.Empty;
    public UserRole Role { get; set; }
}
