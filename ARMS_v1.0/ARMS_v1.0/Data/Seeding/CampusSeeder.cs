using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class CampusSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public CampusSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed campus
            modelBuilder.Entity<Campus>().HasData(
                new Campus() { CampusId = "Hanoi", CampusName = "Hà Nội" },
                new Campus() { CampusId = "Danang", CampusName = "Đà Nẵng"},
                new Campus() { CampusId = "Cantho", CampusName = "Cần Thơ"},
                new Campus() { CampusId = "HCM", CampusName = "Tp HCM"},
                new Campus() { CampusId = "Quynhon", CampusName = "Quy Nhơn"}
                );

        }
    }
}
