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
    public class AlumiStudentConfiguration : IEntityTypeConfiguration<AlumiStudent>
    {
        public void Configure(EntityTypeBuilder<AlumiStudent> builder)
        {
            builder.ToTable(nameof(AlumiStudent));
            builder.HasKey(x => x.AlumiStudentId);
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.Desciption).IsRequired();
            builder.Property(x => x.Img).IsRequired();
            builder.Property(x => x.CampusId).IsRequired();
            builder.Property(x => x.SpecializeMajorID).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.AlumiStudents)
                   .HasForeignKey(x => x.CampusId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.SpecializeMajor)
                   .WithMany(c => c.AlumiStudents)
                   .HasForeignKey(x => x.SpecializeMajorID).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}