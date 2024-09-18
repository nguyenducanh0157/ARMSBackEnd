using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class BlogSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public BlogSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<BlogCategory>().HasData(
                new BlogCategory()
                {
                   BlogCategoryId = 1,
                   BlogCategoryName = "Tuyển sinh",
                    CampusId = "Hanoi"
                },
                new BlogCategory()
                {
                    CampusId = "Hanoi",
                    BlogCategoryId = 2,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Hanoi",
                    BlogCategoryId = 3,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 4,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "Danang"
                },
                new BlogCategory()
                {
                    CampusId = "Danang",
                    BlogCategoryId = 5,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Danang",
                    BlogCategoryId = 6,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 7,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "Cantho"
                },
                new BlogCategory()
                {
                    CampusId = "Cantho",
                    BlogCategoryId = 8,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Cantho",
                    BlogCategoryId = 9,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 10,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "HCM"
                },
                new BlogCategory()
                {
                    CampusId = "HCM",
                    BlogCategoryId = 11,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "HCM",
                    BlogCategoryId = 12,
                    BlogCategoryName = "Sự kiện",
                },
                new BlogCategory()
                {
                    BlogCategoryId = 13,
                    BlogCategoryName = "Tuyển sinh",
                    CampusId = "Thanhhoa"
                },
                new BlogCategory()
                {
                    CampusId = "Thanhhoa",
                    BlogCategoryId = 14,
                    BlogCategoryName = "Hoạt động của sinh viên",
                },
                new BlogCategory()
                {
                    CampusId = "Thanhhoa",
                    BlogCategoryId = 15,
                    BlogCategoryName = "Sự kiện",
                }
                );
        }
    }
}
