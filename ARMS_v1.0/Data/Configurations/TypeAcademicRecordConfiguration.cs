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
    public class TypeAcademicRecordConfiguration : IEntityTypeConfiguration<TypeAcademicRecord>
    {
        public void Configure(EntityTypeBuilder<TypeAcademicRecord> builder)
        {
            builder.ToTable(nameof(TypeAcademicRecord));
            builder.HasKey(x => x.ARId);
            builder.Property(x => x.ARName).IsRequired();
            #region config relation
            builder.HasOne(x => x.TypeOfDiploma)
               .WithMany(c => c.TypeAcademicRecords)
               .HasForeignKey(x => x.DiplomaId).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}