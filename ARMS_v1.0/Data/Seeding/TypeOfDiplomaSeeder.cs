using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    internal class TypeOfDiplomaSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public TypeOfDiplomaSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed TypeOfDiploma
            modelBuilder.Entity<TypeOfDiploma>().HasData(
               new TypeOfDiploma() {DiplomaId =1,  DiplomaName ="Tốt nghiệp THCS" },
               new TypeOfDiploma() { DiplomaId = 2, DiplomaName = "Tốt nghiệp Trung cấp loại giỏi" },
               new TypeOfDiploma() { DiplomaId = 3, DiplomaName = "Xét học bạ THPT" },
               new TypeOfDiploma() { DiplomaId = 4, DiplomaName = "Tốt nghiệp THPT" },
               new TypeOfDiploma() { DiplomaId = 5, DiplomaName = "Tốt nghiệp đại học, cao đẳng " }
               );
            // seed TypeAcademicRecord
            modelBuilder.Entity<TypeAcademicRecord>().HasData(
                new TypeAcademicRecord() {ARId="Xet_5ky", ARName= "Xét học bạ 5 kỳ",DiplomaId=3 },
                new TypeAcademicRecord() { ARId = "Xet_3ky", ARName = "Xét học bạ 3 kỳ", DiplomaId =3 },
                new TypeAcademicRecord() { ARId = "Xet_1nam", ARName = "Xét học bạ năm 12", DiplomaId = 3 },
                new TypeAcademicRecord() { ARId = "Xet_3nam", ARName = "Xét học bạ 3 năm", DiplomaId = 3 },
                new TypeAcademicRecord() { ARId = "Xet_lop10_lop11_Hk1_12", ARName = "Xét học bạ lớp 10, lớp 11, HK1 lớp 12", DiplomaId = 3 }
                );
           
        }
    }
}
