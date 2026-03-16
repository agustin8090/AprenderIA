using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AprenderIA.Domain.Entities;

namespace AprenderIA.Infrastructure.Data.Configurations;

public class MaterialSummaryConfiguration: IEntityTypeConfiguration<MaterialSummary>
{
 public void Configure(EntityTypeBuilder<MaterialSummary> builder)
    {
        builder.HasKey(ms => ms.Id);

        builder.HasOne(ms => ms.Material)
               .WithOne(m => m.Summary)
               .HasForeignKey<MaterialSummary>(ms => ms.MaterialId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
