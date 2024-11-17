using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AdmissionTimeSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AdmissionTimeSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed AdmissionTime
            modelBuilder.Entity<AdmissionTime>().HasData(
               new AdmissionTime()
               {
                   AIId = 1,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 1
               },
               new AdmissionTime()
               {
                   AIId = 2,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 1
               },
               new AdmissionTime()
               {
                   AIId = 3,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 1
               },
               new AdmissionTime()
               {
                   AIId = 4,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 2
               },
               new AdmissionTime()
               {
                   AIId = 5,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 2
               },
               new AdmissionTime()
               {
                   AIId = 6,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 2
               },
               new AdmissionTime()
               {
                   AIId = 7,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 3
               },
               new AdmissionTime()
               {
                   AIId = 8,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 3
               },
               new AdmissionTime()
               {
                   AIId = 9,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 3
               },
               new AdmissionTime()
               {
                   AIId = 10,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 4
               },
               new AdmissionTime()
               {
                   AIId = 11,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 4
               },
               new AdmissionTime()
               {
                   AIId = 12,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 4
               },
               new AdmissionTime()
               {
                   AIId = 13,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2023, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 5
               },
               new AdmissionTime()
               {
                   AIId = 14,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2024, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 5
               },
               new AdmissionTime()
               {
                   AIId = 15,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2024, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2024, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 5
               },
               new AdmissionTime()
               {
                   AIId = 16,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 6
               },
               new AdmissionTime()
               {
                   AIId = 17,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 6
               },
               new AdmissionTime()
               {
                   AIId = 18,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 6
               },
               new AdmissionTime()
               {
                   AIId = 19,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 7
               },
               new AdmissionTime()
               {
                   AIId = 20,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 7
               },
               new AdmissionTime()
               {
                   AIId = 21,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 7
               },
               new AdmissionTime()
               {
                   AIId = 22,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 8
               },
               new AdmissionTime()
               {
                   AIId = 23,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 8
               },
               new AdmissionTime()
               {
                   AIId = 24,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 8
               },
               new AdmissionTime()
               {
                   AIId = 25,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 9
               },
               new AdmissionTime()
               {
                   AIId = 26,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 9
               },
               new AdmissionTime()
               {
                   AIId = 27,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 9
               },
               new AdmissionTime()
               {
                   AIId = 28,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2022, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2022, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 10
               },
               new AdmissionTime()
               {
                   AIId = 29,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2023, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 10
               },
               new AdmissionTime()
               {
                   AIId = 30,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2023, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2023, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2023, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2023, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 10
               },
               new AdmissionTime()
               {
                   AIId = 31,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 11
               },
               new AdmissionTime()
               {
                   AIId = 32,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 11
               },
               new AdmissionTime()
               {
                   AIId = 33,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 11
               },
               new AdmissionTime()
               {
                   AIId = 34,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 12
               },
               new AdmissionTime()
               {
                   AIId = 35,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 12
               },
               new AdmissionTime()
               {
                   AIId = 36,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 12
               },
               new AdmissionTime()
               {
                   AIId = 37,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 13
               },
               new AdmissionTime()
               {
                   AIId = 38,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 13
               },
               new AdmissionTime()
               {
                   AIId = 39,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 13
               },
               new AdmissionTime()
               {
                   AIId = 40,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 14
               },
               new AdmissionTime()
               {
                   AIId = 41,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 14
               },
               new AdmissionTime()
               {
                   AIId = 42,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 14
               },
               new AdmissionTime()
               {
                   AIId = 43,
                   AdmissionInformationName = "Đợt 1",
                   StartRegister = new DateTime(2024, 09, 01, 00, 00, 0),
                   EndRegister = new DateTime(2024, 12, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 1, 30, 23, 59, 59),
                   AdmissionInformationID = 15
               },
               new AdmissionTime()
               {
                   AIId = 44,
                   AdmissionInformationName = "Đợt 2",
                   StartRegister = new DateTime(2025, 1, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 4, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 5, 30, 23, 59, 59),
                   AdmissionInformationID = 15
               },
               new AdmissionTime()
               {
                   AIId = 45,
                   AdmissionInformationName = "Đợt 3",
                   StartRegister = new DateTime(2025, 5, 01, 00, 00, 0),
                   EndRegister = new DateTime(2025, 8, 30, 23, 59, 59),
                   StartAdmission = new DateTime(2025, 8, 15, 00, 00, 0),
                   EndAdmission = new DateTime(2025, 8, 30, 23, 59, 59),
                   AdmissionInformationID = 15
               }
                );

        }
    }
}
