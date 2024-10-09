//using Data.Models;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Data.Configurations
//{
//    public class AdmissionTimeConfiguration : IEntityTypeConfiguration<AdmissionTime>
//    {
//        public void Configure(EntityTypeBuilder<AdmissionTime> builder)
//        {
//            builder.ToTable(nameof(AdmissionTime));
//            builder.HasKey(x => x.AdmissionTimeID);
//            builder.Property(x => x.AdmissionTimeName).IsRequired();
//            builder.Property(x => x.TimeStart).IsRequired();
//            builder.Property(x => x.TimeEnd).IsRequired();
//            #region config relation
//            builder.HasOne(x => x.AdmissionPlan)
//                   .WithMany(c => c.AdmissionTimes)
//                   .HasForeignKey(x => x.AdmissionPlanID).OnDelete(DeleteBehavior.NoAction);
//            #endregion
//        }
//    }
//}