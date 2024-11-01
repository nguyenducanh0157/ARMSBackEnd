using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class TypeAdmissionSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public TypeAdmissionSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed TypeAdmission
            modelBuilder.Entity<TypeAdmission>().HasData(
                new TypeAdmission()
                {
                    MajorID = "HME",
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,
                    
                },
                 new TypeAdmission()
                 {
                     MajorID = "HME",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 }
                 ,
                 new TypeAdmission()
                 {
                     MajorID = "HJA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HJA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HJA",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HKA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HKA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HKA",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HSM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HSM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HSM",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HHM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HHM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HHM",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HRM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HRM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HRM",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HBT",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HBT",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HBT",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HBS",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HBS",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HBS",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HAO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HAO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HAO",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HSO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HSO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HSO",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HFO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HFO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HFO",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SME",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SME",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SME",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SGE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SGE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SGE",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SWE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SWE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SWE",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "STE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "STE",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "STE",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SEA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SEA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SEA",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SJA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SJA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SJA",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SKA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SKA",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SKA",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SSM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SSM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SSM",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SHM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SHM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SHM",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SRM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SRM",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SRM",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SBT",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SBT",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SBT",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SBS",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SBS",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SBS",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SAO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SAO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SAO",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SSO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SSO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SSO",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "SFO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SFO",
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "SFO",
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 }
                );

        }
    }
}
