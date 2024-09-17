using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class SpecializeMajorSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public SpecializeMajorSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed SpecializeMajor
            modelBuilder.Entity<SpecializeMajor>().HasData(
                new SpecializeMajor() { MajorID = "E", SpecializeMajorID = "ME", SpecializeMajorName = "Lập trình mobile" },
                new SpecializeMajor() { MajorID = "E", SpecializeMajorID = "GE", SpecializeMajorName = "Lập trình game" },
                new SpecializeMajor() { MajorID = "E", SpecializeMajorID = "WE", SpecializeMajorName = "Lập trình web" },
                new SpecializeMajor() { MajorID = "E", SpecializeMajorID = "TE", SpecializeMajorName = "Kiểm thử" },

                new SpecializeMajor() { MajorID = "A", SpecializeMajorID = "EA", SpecializeMajorName = "Ngôn ngữ anh" },
                new SpecializeMajor() { MajorID = "A", SpecializeMajorID = "JA", SpecializeMajorName = "Ngôn ngữ nhật" },
                new SpecializeMajor() { MajorID = "A", SpecializeMajorID = "KA", SpecializeMajorName = "Ngôn ngữ hàn" },

                new SpecializeMajor() { MajorID = "S", SpecializeMajorID = "SM", SpecializeMajorName = "Marketing" },
                new SpecializeMajor() { MajorID = "S", SpecializeMajorID = "HM", SpecializeMajorName = "Quản trị khách sạn" },
                new SpecializeMajor() { MajorID = "S", SpecializeMajorID = "RM", SpecializeMajorName = "Quản trị nhà hàng" },

                new SpecializeMajor() { MajorID = "B", SpecializeMajorID = "BT", SpecializeMajorName = "Phum xăm thẩm mỹ" },
                new SpecializeMajor() { MajorID = "B", SpecializeMajorID = "BS", SpecializeMajorName = "Chăm sóc da và massage" },

                new SpecializeMajor() { MajorID = "O", SpecializeMajorID = "AO", SpecializeMajorName = "Kiểm toán" },
                new SpecializeMajor() { MajorID = "O", SpecializeMajorID = "SO", SpecializeMajorName = "Thư ký văn phòng" },
                new SpecializeMajor() { MajorID = "O", SpecializeMajorID = "FO", SpecializeMajorName = "Kỹ thuật chế biến món ăn" }
                );

        }
    }
}
