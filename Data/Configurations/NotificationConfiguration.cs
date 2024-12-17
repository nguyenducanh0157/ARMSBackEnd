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
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable(nameof(Notification));
            builder.HasKey(x => x.NotificationId);

            #region config relation
            builder.HasOne(x => x.Account)
                   .WithMany(c => c.Notifications)
                   .HasForeignKey(x => x.AccountId);
            #endregion
        }
    }
}