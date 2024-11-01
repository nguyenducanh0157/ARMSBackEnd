//using Data.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Data.Seeding
//{
//    public class AdmissionGroupSeeder
//    {
//        private readonly ModelBuilder modelBuilder;

//        public AdmissionGroupSeeder(ModelBuilder modelBuilder)
//        {
//            this.modelBuilder = modelBuilder;
//        }
//        public void Seed()
//        {
//            // seed TypeAdmission
//            modelBuilder.Entity<AdmissionGroup>().HasData(
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 1,
//                    CampusId ="Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic=24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A00
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 2,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A01
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 3,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A02
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 4,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A03
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 5,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A04
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 6,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A05
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 7,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A06
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 8,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A07
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 9,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A08
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 10,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A09
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 11,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A10
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 12,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.A11
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 13,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.B00
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 14,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.B01
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 15,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.B02
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 16,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.B03
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 17,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.B04
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 18,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.B06
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 19,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C00
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 20,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C01
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 21,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C02
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 22,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C03
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 23,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C04
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 24,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C05
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 25,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C06
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 26,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C07
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 27,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C08
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 28,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C09
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 29,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C10
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 30,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C12
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 31,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C13
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 32,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C14
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 33,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C16
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 34,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C17
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 35,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C19
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 36,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.C20
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 37,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D01
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 38,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D02
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 39,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D07
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 40,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D08
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 41,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D09
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 42,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D10
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 43,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D11
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 44,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D12
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 45,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D13
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 46,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D14
//                },
//                new AdmissionGroup()
//                {
//                    AdmissionGroupId = 47,
//                    CampusId = "Hanoi",
//                    Year = 2024,
//                    TotalScore = 24,
//                    TotalScoreAcademic = 24,
//                    StatusScore = true,
//                    StatusScoreAcademic = true,
//                    SubjectGroup = SubjectGroup.D15
//                }
//                );

//        }
//    }
//}