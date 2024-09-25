using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AdmissionPlanSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AdmissionPlanSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed AdmissionPlan
            modelBuilder.Entity<AdmissionPlan>().HasData(
                new AdmissionPlan() { AdmissionPlanID = 1, CampusId ="Hanoi", TotalTarget = 2000, Prioritize = "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.", YearAdmission=2024},
                new AdmissionPlan() { AdmissionPlanID = 2, CampusId = "Danang", TotalTarget = 2000, Prioritize = "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.", YearAdmission = 2024 },
                new AdmissionPlan() { AdmissionPlanID = 3, CampusId = "Cantho", TotalTarget = 2000, Prioritize = "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.", YearAdmission = 2024 },
                new AdmissionPlan() { AdmissionPlanID = 4, CampusId = "HCM", TotalTarget = 2000, Prioritize = "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.", YearAdmission = 2024 },
                new AdmissionPlan() { AdmissionPlanID = 5, CampusId = "Thanhhoa", TotalTarget = 2000, Prioritize = "Điểm ưu tiên đối tượng và khu vực thực hiện theo Quy định của Bộ Giáo dục & Đào tạo.", YearAdmission = 2024 }
                );
            // seed AdmissionTime
            modelBuilder.Entity<AdmissionTime>().HasData(
                new AdmissionTime() { AdmissionPlanID = 1, AdmissionTimeID = 1, AdmissionTimeName = "Đợt 1", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 1, AdmissionTimeID = 2, AdmissionTimeName = "Đợt 2", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 1, AdmissionTimeID = 3, AdmissionTimeName = "Đợt 3", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },

                new AdmissionTime() { AdmissionPlanID = 2, AdmissionTimeID = 4, AdmissionTimeName = "Đợt 1", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 2, AdmissionTimeID = 5, AdmissionTimeName = "Đợt 2", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 2, AdmissionTimeID = 6, AdmissionTimeName = "Đợt 3", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },

                new AdmissionTime() { AdmissionPlanID = 3, AdmissionTimeID = 7, AdmissionTimeName = "Đợt 1", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 3, AdmissionTimeID = 8, AdmissionTimeName = "Đợt 2", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 3, AdmissionTimeID = 9, AdmissionTimeName = "Đợt 3", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },

                new AdmissionTime() { AdmissionPlanID = 4, AdmissionTimeID = 10, AdmissionTimeName = "Đợt 1", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 4, AdmissionTimeID = 11, AdmissionTimeName = "Đợt 2", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 4, AdmissionTimeID = 12, AdmissionTimeName = "Đợt 3", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },

                new AdmissionTime() { AdmissionPlanID = 5, AdmissionTimeID = 13, AdmissionTimeName = "Đợt 1", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 5, AdmissionTimeID = 14, AdmissionTimeName = "Đợt 2", TimeStart = DateTime.Now, TimeEnd = DateTime.Now },
                new AdmissionTime() { AdmissionPlanID = 5, AdmissionTimeID = 15, AdmissionTimeName = "Đợt 3", TimeStart = DateTime.Now, TimeEnd = DateTime.Now }
                );
        }
    }
}
