using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AdmissionDetailForMajorSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AdmissionDetailForMajorSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<AdmissionDetailForMajor>().HasData(
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.Parse("5C8E9972-7642-4B08-9642-C510E3CD40DC"),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HME",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.Parse("664B31E7-4A22-4D47-A46C-2E2876337AC7"),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HGE",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.Parse("257447A5-016C-40D9-9C5F-1A2CC68E0654"),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HWE",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                }
                ,
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.Parse("B7328CAD-128F-4DA3-9CFA-0BD91116275A"),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HTE",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.Parse("CFB75E89-ECD3-4071-9245-2E7286B6F84D"),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HEA",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.D01, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.Parse("3ED63CEC-79A4-4304-BFA0-A326A4DBB03D"),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HJA",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HKA",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HSM",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HHM",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                }
                ,
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HRM",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HBT",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HBS",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HAO",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HSO",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "HFO",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                //hcm 

                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SME",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SGE",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SWE",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                }
                ,
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "STE",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SEA",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.D01, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SJA",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SKA",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SSM",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SHM",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                }
                ,
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SRM",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SBT",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SBS",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SAO",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SSO",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new AdmissionDetailForMajor()
                {
                    ADMId = Guid.NewGuid(),
                    Year = 2024,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    StatusScore = true,
                    StatusScoreAcademic = true,
                    MajorID = "SFO",
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                }
                );
        }
    }

}
