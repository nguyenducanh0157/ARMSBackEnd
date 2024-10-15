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
                new IdentityRole<Guid>() { Id = Guid.Parse("D2D63C5B-D09B-4828-8322-F18BA103FE86"), Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole<Guid>() { Id = Guid.Parse("62378687-E16C-4D94-B767-DE9F0BFE9498"), Name = "AdminOfficer", NormalizedName = "ADMINOFFICER" },
                new IdentityRole<Guid>() { Id = Guid.Parse("602F7A5F-E0A7-4C00-9DA0-A413BFCFAB3A"), Name = "SchoolService", NormalizedName = "SCHOOLSERVICE" }
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
                },
                 new Account()
                 {
                     Id = Guid.Parse("5738248D-B40E-4332-9B9E-DEB0ABC8F8DD"),
                     UserName = "adminofficer",
                     NormalizedUserName = "ADMINOFFICER",
                     Email = "adminofficer@gmail.com",
                     NormalizedEmail = "ADMINOFFICER@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = new PasswordHasher<Account>().HashPassword(null, "adminofficer@123"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                     CampusId = "Hanoi",
                     Fullname = "Admin Officer Hanoi"
                 },
                 new Account()
                 {
                     Id = Guid.Parse("17BAF918-D5D2-4628-AAD1-8A4926520676"),
                     UserName = "schoolservice",
                     NormalizedUserName = "SCHOOLSERVICE",
                     Email = "schoolservice@gmail.com",
                     NormalizedEmail = "SCHOOLSERVICE@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = new PasswordHasher<Account>().HashPassword(null, "schoolservice@123"),
                     SecurityStamp = Guid.NewGuid().ToString(),
                     CampusId = "Hanoi",
                     Fullname = "School Service Hanoi"
                 });

            // Seed User in role
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                //Seed admin

                new IdentityUserRole<Guid> { UserId = Guid.Parse("B8C777A9-55B9-4B3D-860A-D7B56E4C24B7"), RoleId = Guid.Parse("B8FD818F-63F1-49EE-BEC5-F7B66CAFBFCA") },
                //seed admin officer
                new IdentityUserRole<Guid> { UserId = Guid.Parse("5738248D-B40E-4332-9B9E-DEB0ABC8F8DD"), RoleId = Guid.Parse("62378687-E16C-4D94-B767-DE9F0BFE9498") },
                //seed school service
                new IdentityUserRole<Guid> { UserId = Guid.Parse("17BAF918-D5D2-4628-AAD1-8A4926520676"), RoleId = Guid.Parse("602F7A5F-E0A7-4C00-9DA0-A413BFCFAB3A") }
                ////seed admin council
                //new IdentityUserRole<Guid> { UserId = Guid.Parse("5738248D-B40E-4332-9B9E-DEB0ABC8F8DD"), RoleId = Guid.Parse("62378687-E16C-4D94-B767-DE9F0BFE9498") },
                ////seed student
                //new IdentityUserRole<Guid> { UserId = Guid.Parse("5738248D-B40E-4332-9B9E-DEB0ABC8F8DD"), RoleId = Guid.Parse("62378687-E16C-4D94-B767-DE9F0BFE9498") },
                );
        }
    }
}
