using System;
using AprenderIA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AprenderIA.Infrastructure.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Name)
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(u => u.Role)
               .HasConversion<string>()
               .HasMaxLength(20);
    }
}
