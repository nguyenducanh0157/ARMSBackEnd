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
            // seed TypeOfDiploma
            modelBuilder.Entity<TypeOfDiploma>().HasData(
                new TypeOfDiploma() { AdmissionPlanID = 1, DiplomaId = 1, DiplomaName = "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 1, DiplomaId = 2, DiplomaName = "Tốt nghiệp THCS" },
                new TypeOfDiploma() { AdmissionPlanID = 1, DiplomaId = 3, DiplomaName = "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 1, DiplomaId = 4, DiplomaName = "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },

                new TypeOfDiploma() { AdmissionPlanID = 2, DiplomaId = 5, DiplomaName = "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 2, DiplomaId = 6, DiplomaName = "Tốt nghiệp THCS" },
                new TypeOfDiploma() { AdmissionPlanID = 2, DiplomaId = 7, DiplomaName = "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 2, DiplomaId = 8, DiplomaName = "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },

                new TypeOfDiploma() { AdmissionPlanID = 3, DiplomaId = 9, DiplomaName = "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 3, DiplomaId = 10, DiplomaName = "Tốt nghiệp THCS" },
                new TypeOfDiploma() { AdmissionPlanID = 3, DiplomaId = 11, DiplomaName = "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 3, DiplomaId = 12, DiplomaName = "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },

                new TypeOfDiploma() { AdmissionPlanID = 4, DiplomaId = 13, DiplomaName = "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 4, DiplomaId = 14, DiplomaName = "Tốt nghiệp THCS" },
                new TypeOfDiploma() { AdmissionPlanID = 4, DiplomaId = 15, DiplomaName = "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 4, DiplomaId = 16, DiplomaName = "Tốt nghiệp ĐH-CD-TC- Học 1 năm" },

                new TypeOfDiploma() { AdmissionPlanID = 5, DiplomaId = 17, DiplomaName = "Tốt nghiệp THCS, học lớp 10,11,12 - học 2 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 5, DiplomaId = 18, DiplomaName = "Tốt nghiệp THCS" },
                new TypeOfDiploma() { AdmissionPlanID = 5, DiplomaId = 19, DiplomaName = "Tốt nghiệp THPT hoặc bổ túc THPT - Học 1 năm đến 1,5 năm" },
                new TypeOfDiploma() { AdmissionPlanID = 5, DiplomaId = 20, DiplomaName = "Tốt nghiệp ĐH-CD-TC- Học 1 năm" }
                );
        }
    }
}
