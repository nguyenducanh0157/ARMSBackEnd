using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class StudentProfileSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public StudentProfileSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed TypeAdmission
            modelBuilder.Entity<StudentProfile>().HasData(
                new StudentProfile()
                {
                    SpId = Guid.Parse("41A2AD7D-1AF6-464E-BBF4-0D18AE664851"),
                    AccountId = Guid.Parse("2F36AD81-47C3-4194-9AF8-BA19300695AA"),
                    Fullname ="Nguyễn Đức Anh",
                    CampusId ="Hanoi",
                    CitizenIentificationNumber ="038301012121",
                    CIDate = DateTime.Now,
                    CIAddress ="HCM",
                    EmailStudent = "nguyenducanh01.57@gmail.com",
                    Major1 = "HAO",
                    PhoneStudent ="0971341555",
                    Dob = DateTime.Now,
                    Gender = true,
                    TypeofStatus = TypeofStatus.Inprocess,
                    TimeRegister = DateTime.Now,
                    TypeOfDiploma = TypeOfDiploma.Xet_diem_thi_THPT,
                    PriorityDetailPriorityID = 1,
                },
                new StudentProfile()
                {
                    SpId = Guid.Parse("795B3E70-1312-4889-8352-A696757D1730"),
                    Fullname = "Truong Thi Thu",
                    CampusId = "Hanoi",
                    CitizenIentificationNumber = "038301010101",
                    CIDate = DateTime.Now,
                    CIAddress = "HCM",
                    EmailStudent = "hoaithu1707.25@gmail.com",
                    Major1 = "HAO",
                    PhoneStudent = "0971341554",
                    Dob = DateTime.Now,
                    Gender = true,
                    TypeofStatus = TypeofStatus.Inprocess,
                    TimeRegister = DateTime.Now,
                    TypeOfDiploma = TypeOfDiploma.Xet_diem_thi_THPT,
                    PriorityDetailPriorityID = 1,
                }
                );
            modelBuilder.Entity<AcademicTranscript>().HasData(
                new AcademicTranscript()
                {
                    ATId = Guid.NewGuid(),
                    SpId = Guid.Parse("41A2AD7D-1AF6-464E-BBF4-0D18AE664851"),
                    SubjectName ="Toán",
                    SubjectPoint = 9,
                    TypeOfAcademicTranscript = TypeOfAcademicTranscript.Mon1_C1,

                },
                new AcademicTranscript()
                {
                    ATId = Guid.NewGuid(),
                    SpId = Guid.Parse("41A2AD7D-1AF6-464E-BBF4-0D18AE664851"),
                    SubjectName = "Văn",
                    SubjectPoint = 9,
                    TypeOfAcademicTranscript = TypeOfAcademicTranscript.Mon2_C1,

                },
                new AcademicTranscript()
                {
                    ATId = Guid.NewGuid(),
                    SpId = Guid.Parse("41A2AD7D-1AF6-464E-BBF4-0D18AE664851"),
                    SubjectName = "Anh",
                    SubjectPoint = 9,
                    TypeOfAcademicTranscript = TypeOfAcademicTranscript.Mon3_C1,

                },
                new AcademicTranscript()
                {
                    ATId = Guid.NewGuid(),
                    SpId = Guid.Parse("795B3E70-1312-4889-8352-A696757D1730"),
                    SubjectName = "Toán",
                    SubjectPoint = 9,
                    TypeOfAcademicTranscript = TypeOfAcademicTranscript.Mon1_C1,

                },
                new AcademicTranscript()
                {
                    ATId = Guid.NewGuid(),
                    SpId = Guid.Parse("795B3E70-1312-4889-8352-A696757D1730"),
                    SubjectName = "Văn",
                    SubjectPoint = 9,
                    TypeOfAcademicTranscript = TypeOfAcademicTranscript.Mon2_C1,

                },
                new AcademicTranscript()
                {
                    ATId = Guid.NewGuid(),
                    SpId = Guid.Parse("795B3E70-1312-4889-8352-A696757D1730"),
                    SubjectName = "Anh",
                    SubjectPoint = 9,
                    TypeOfAcademicTranscript = TypeOfAcademicTranscript.Mon3_C1,

                }
                );
        }
    }
}