using System;
using AprenderIA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AprenderIA.Infrastructure.Data.Configurations;

public class PracticeQuizConfiguration: IEntityTypeConfiguration<PracticeQuiz>
{
public void Configure(EntityTypeBuilder<PracticeQuiz> builder)
    {
        builder.HasKey(pq => pq.Id);

        builder.Property(pq => pq.Title).HasMaxLength(200).IsRequired();

        builder.HasOne(pq => pq.Material)
               .WithMany(m => m.PracticeQuizzes)
               .HasForeignKey(pq => pq.MaterialId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
