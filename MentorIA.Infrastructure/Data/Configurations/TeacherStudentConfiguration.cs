using System;
using AprenderIA.Domain.Entities;
using AprenderIA.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AprenderIA.Infrastructure.Data.Configurations;

public class TeacherStudentConfiguration:IEntityTypeConfiguration<TeacherStudent>
{
 public void Configure(EntityTypeBuilder<TeacherStudent> builder)
    {
     builder.HasKey(ts => new { ts.TeacherId, ts.StudentId });

        builder.Property(ts => ts.TeacherId).HasColumnName("TeacherId");
        builder.Property(ts => ts.StudentId).HasColumnName("StudentId");

        builder.HasOne<ApplicationUser>()
               .WithMany()
               .HasForeignKey(ts => ts.TeacherId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ApplicationUser>()
               .WithMany()
               .HasForeignKey(ts => ts.StudentId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
