using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class MajorSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public MajorSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed Major
            modelBuilder.Entity<Major>().HasData(
                new Major() { MajorID = "E", MajorName = "Công nghệ thông tin", CampusId = "Hanoi",Target=200 },
                new Major() { MajorID = "A", MajorName = "Ngôn ngữ", CampusId = "Hanoi", Target = 200 },
                new Major() { MajorID = "S", MajorName = "Quản trị kinh doanh", CampusId = "Hanoi", Target = 200 },
                new Major() { MajorID = "B", MajorName = "Làm đẹp", CampusId = "Hanoi", Target = 200 },
                new Major() { MajorID = "O", MajorName = "Ngành khác", CampusId = "Hanoi", Target = 200 }
                );

        }
    }
}
