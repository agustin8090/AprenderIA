// AprenderIA.Infrastructure/Data/AprenderIADbContext.cs
using AprenderIA.Domain.Entities;
using AprenderIA.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AprenderIA.Infrastructure.Data;

public class AprenderIADbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public AprenderIADbContext(DbContextOptions<AprenderIADbContext> options) : base(options) { }

    public DbSet<Material> Materials => Set<Material>();
    public DbSet<MaterialSummary> MaterialSummaries => Set<MaterialSummary>();
    public DbSet<PracticeQuiz> PracticeQuizzes => Set<PracticeQuiz>();
    public DbSet<QuizQuestions> QuizQuestions => Set<QuizQuestions>();
    public DbSet<TeacherStudent> TeacherStudents => Set<TeacherStudent>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(AprenderIADbContext).Assembly);
        builder.Ignore<AprenderIA.Domain.Entities.User>();
    }
}
