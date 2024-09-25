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
    public class TypeAdmissionForMajorConfiguration : IEntityTypeConfiguration<TypeAdmissionForMajor>
    {
        public void Configure(EntityTypeBuilder<TypeAdmissionForMajor> builder)
        {
            builder.ToTable(nameof(TypeAdmissionForMajor));
            builder.HasKey(x => new { x.DiplomaId, x.SpecializeMajorID });
            builder.Property(x => x.ARId).IsRequired(false);
            #region config relation
            builder.HasOne(x => x.TypeOfDiploma)
               .WithMany(c => c.TypeAdmissionForMajors)
               .HasForeignKey(x => x.DiplomaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.SpecializeMajor)
              .WithMany(c => c.TypeAdmissionForMajors)
              .HasForeignKey(x => x.SpecializeMajorID).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.TypeAcademicRecord)
                   .WithMany(c => c.TypeAdmissionForMajors)
                   .HasForeignKey(x => x.ARId)
                   .OnDelete(DeleteBehavior.NoAction);

            #endregion
        }
    }
}