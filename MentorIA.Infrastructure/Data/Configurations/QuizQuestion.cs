using System;
using AprenderIA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AprenderIA.Infrastructure.Data.Configurations;

public class QuizQuestionConfiguration: IEntityTypeConfiguration<QuizQuestions>
{
  public void Configure(EntityTypeBuilder<QuizQuestions> builder)
    {
        builder.HasKey(qq => qq.Id);

        builder.Property(qq => qq.QuestionText).HasMaxLength(500).IsRequired();
        builder.Property(qq => qq.CorrectOption).HasMaxLength(1).IsRequired();

        builder.HasOne(qq => qq.PracticeQuiz)
               .WithMany(pq => pq.Questions)
               .HasForeignKey(qq => qq.PracticeQuizId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
