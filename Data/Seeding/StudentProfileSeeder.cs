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
                    Fullname = "Nguyễn Đức Anh",
                    CampusId = "Hanoi",
                    CitizenIentificationNumber = "038301012121",
                    CIDate = DateTime.Now,
                    CIAddress = "HCM",
                    EmailStudent = "nguyenducanh01.57@gmail.com",
                    Major1 = "HAO",
                    Major2 = "HWE",
                    PhoneStudent = "0971341555",
                    Dob = DateTime.Now,
                    Gender = true,
                    TypeofStatusMajor1 = TypeofStatusForMajor.Inprocess,
                    TypeofStatusMajor2 = TypeofStatusForMajor.Inprocess,
                    TypeofStatusProfile = TypeofStatus.ConfirmSuccessProfileRegister,
                    TimeRegister = DateTime.Now,
                    TypeOfDiplomaMajor1 = TypeOfDiploma.Xet_diem_thi_THPT,
                    TypeOfDiplomaMajor2 = TypeOfDiploma.Xet_diem_thi_THPT,
                    PriorityDetailPriorityID = 1,
                });
                
        }
    }
}