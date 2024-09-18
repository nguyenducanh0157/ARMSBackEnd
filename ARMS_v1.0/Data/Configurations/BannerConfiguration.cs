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
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.ToTable(nameof(Banner));
            builder.Property(x => x.BannerId).IsRequired();
            builder.Property(x => x.Img).IsRequired();
            builder.Property(x => x.CampusId).IsRequired();

            #region config relation
            builder.HasOne(x => x.Campus)
                   .WithMany(c => c.Banners)
                   .HasForeignKey(x => x.CampusId);
            #endregion
        }
    }
}