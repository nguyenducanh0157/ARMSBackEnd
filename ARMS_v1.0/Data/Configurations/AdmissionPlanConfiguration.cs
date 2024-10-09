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
//    public class AdmissionPlanConfiguration : IEntityTypeConfiguration<AdmissionPlan>
//    {
//        public void Configure(EntityTypeBuilder<AdmissionPlan> builder)
//        {
//            builder.ToTable(nameof(AdmissionPlan));
//            builder.HasKey(x => x.AdmissionPlanID);
//            builder.Property(x => x.TotalTarget).IsRequired();
//            #region config relation
//            builder.HasOne(x => x.Campus)
//                   .WithOne(c => c.AdmissionPlan)
//                   .HasForeignKey<Campus>(x => x.AdmissionPlanID).OnDelete(DeleteBehavior.NoAction);
//            #endregion
//        }
//    }
//}