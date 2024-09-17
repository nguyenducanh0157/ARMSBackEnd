using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class SpecializeMajorConfiguration : IEntityTypeConfiguration<SpecializeMajor>
    {
        public void Configure(EntityTypeBuilder<SpecializeMajor> builder)
        {
            builder.ToTable(nameof(SpecializeMajor));
            builder.Property(x => x.SpecializeMajorID).IsRequired();
            builder.Property(x => x.SpecializeMajorName).IsRequired();

            #region config relation
            builder.HasOne(x => x.Major)
                   .WithMany(c => c.SpecializeMajors)
                   .HasForeignKey(x => x.MajorID);
            #endregion
        }
    }
}
