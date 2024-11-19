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
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                 new TypeAdmission()
                 {
                     MajorID = "HME",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 }
                 ,
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HJA",
                     AdmissionInformationID = 1,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                new TypeAdmission()
                {
                    MajorID = "HJA",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HJA",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionInformationID = 1,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                 // 11
                 new TypeAdmission()
                 {
                     MajorID = "HME",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HME",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HGE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HWE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HTE",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                 }
                 ,
                 new TypeAdmission()
                 {
                     MajorID = "HEA",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                     TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                 },
                 new TypeAdmission()
                 {
                     MajorID = "HJA",
                     AdmissionInformationID = 11,
                     TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                 },
                new TypeAdmission()
                {
                    MajorID = "HJA",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HJA",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HKA",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HSM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HHM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HRM",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HBT",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HBS",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HAO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HSO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_CD_DH,

                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Tot_nghiep_THPT,

                },
                new TypeAdmission()
                {
                    MajorID = "HFO",
                    AdmissionInformationID = 11,
                    TypeDiploma = TypeOfDiploma.Xet_hoc_ba_THPT,
                    TypeOfTranscript = TypeOfTranscript.Xet_hoc_ba_3nam
                });
        }
    }
}
