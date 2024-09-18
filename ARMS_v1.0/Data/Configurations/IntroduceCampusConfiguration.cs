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
    public class IntroduceCampusConfiguration : IEntityTypeConfiguration<IntroduceCampus>
    {
        public void Configure(EntityTypeBuilder<IntroduceCampus> builder)
        {
            builder.ToTable(nameof(IntroduceCampus));
            builder.HasKey(x => x.IntroduceId);
            builder.Property(x => x.History).IsRequired(false);
            builder.Property(x => x.TrainingMotto).IsRequired(false);
            builder.Property(x => x.Achievements).IsRequired(false);
            builder.Property(x => x.WhyChooseUs).IsRequired(false);
            builder.Property(x => x.CampusId).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus)
                   .WithOne(sp => sp.IntroduceCampus)
                   .HasForeignKey<Campus>(sp => sp.IntroduceId);
            #endregion
        }
    }
}