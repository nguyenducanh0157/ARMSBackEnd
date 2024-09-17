using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AccountSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AccountSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {


            // Seed role data
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>() { Id = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA"), Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<Guid>() { Id = Guid.Parse("D2D63C5B-D09B-4828-8322-F18BA103FE86"), Name = "Student", NormalizedName = "STUDENT" }
            );

            //Seed Account
            modelBuilder.Entity<Account>().HasData(
                new Account()
                {
                    Id = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"),
                    UserName = "Administrator",
                    NormalizedUserName = "ADMINISTRATOR",
                    Email = "AdminHaNoi@gmail.com",
                    NormalizedEmail = "ADMINHANOI@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "AdminHn@123"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CampusId = "Hanoi",
                    Fullname = "Admin Hanoi"
                });

            // Seed User in role
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                //Seed admin

                new IdentityUserRole<Guid> { UserId = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") }

                );
        }
    }
}
