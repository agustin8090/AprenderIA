// MentorIA.Infrastructure/Data/AprenderIADbContextFactory.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AprenderIA.Infrastructure.Data;

public class AprenderIADbContextFactory : IDesignTimeDbContextFactory<AprenderIADbContext>
{
    public AprenderIADbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AprenderIADbContext>();
        optionsBuilder.UseSqlServer("Server=localhost;Database=AprenderIA;User Id=SA;Password=MyStrongPass123;TrustServerCertificate=True;");

        return new AprenderIADbContext(optionsBuilder.Options);
    }
}
