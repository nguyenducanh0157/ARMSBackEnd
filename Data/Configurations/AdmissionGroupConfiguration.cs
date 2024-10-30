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
    public class AdmissionGroupConfiguration : IEntityTypeConfiguration<AdmissionGroup>
    {
        public void Configure(EntityTypeBuilder<AdmissionGroup> builder)
        {
            builder.ToTable(nameof(AdmissionGroup));
            builder.HasKey(x => x.AdmissionGroupId);
            builder.Property(x => x.StatusScore).IsRequired();
            builder.Property(x => x.CampusId).IsRequired();
            builder.Property(x => x.StatusScoreAcademic).IsRequired();
            builder.Property(x => x.SubjectGroup).IsRequired();
            builder.Property(x => x.TotalScore).IsRequired();
            builder.Property(x => x.TotalScoreAcademic).IsRequired();
            builder.Property(x => x.Year).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus).WithMany(x => x.AdmissionGroups).HasForeignKey(x => x.CampusId).OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}