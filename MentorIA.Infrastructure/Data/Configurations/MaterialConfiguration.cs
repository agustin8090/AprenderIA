using System;
using AprenderIA.Domain.Entities;
using AprenderIA.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AprenderIA.Infrastructure.Data.Configurations;

public class MaterialConfiguration: IEntityTypeConfiguration<Material>
{
   public void Configure(EntityTypeBuilder<Material> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Title).HasMaxLength(200).IsRequired();
        builder.Property(m => m.FileUrl).HasMaxLength(500).IsRequired();
        builder.Property(m => m.FileName).HasMaxLength(200).IsRequired();
        builder.Property(m => m.contentType).HasMaxLength(100).IsRequired();

        builder.HasOne<ApplicationUser>()
               .WithMany()
               .HasForeignKey(m => m.TeacherId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
