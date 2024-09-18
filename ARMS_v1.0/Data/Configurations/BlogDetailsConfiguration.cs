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
    public class BlogDetailsConfiguration : IEntityTypeConfiguration<BlogDetails>
    {
        public void Configure(EntityTypeBuilder<BlogDetails> builder)
        {
            builder.ToTable(nameof(BlogDetails));
            builder.HasKey(x => x.BDId);
            builder.Property(x => x.BlogId).IsRequired();
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.Img).IsRequired(false);
            builder.Property(x => x.TitleImg).IsRequired(false);
            #region config relation
            builder.HasOne(x => x.Blog)
                   .WithMany(c => c.BlogDetails)
                   .HasForeignKey(x => x.BlogId);
            #endregion
        }
    }
}
