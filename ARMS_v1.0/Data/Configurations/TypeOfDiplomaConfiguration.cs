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
    public class TypeOfDiplomaConfiguration : IEntityTypeConfiguration<TypeOfDiploma>
    {
        public void Configure(EntityTypeBuilder<TypeOfDiploma> builder)
        {
            builder.ToTable(nameof(TypeOfDiploma));
            builder.HasKey(x => x.DiplomaId);
            builder.Property(x => x.DiplomaName).IsRequired();
            #region config relation
            builder.HasOne(x => x.AdmissionPlan)
                   .WithMany(c => c.TypeOfDiplomas)
                   .HasForeignKey(x => x.AdmissionPlanID).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}