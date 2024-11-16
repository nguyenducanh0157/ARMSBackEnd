using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class MajorAdmissionSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public MajorAdmissionSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<MajorAdmission>().HasData(
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HME",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HGE",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HWE",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HTE", // Ensure no duplicates
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HEA",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HJA",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HKA",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HSM",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HHM",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HRM",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HBT",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HBS",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HAO",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HSO",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionInformationID = 1,
                    MajorID = "HFO",
                    Status = false,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                }
            );
        }

    }
}
