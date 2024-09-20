using Data.Configurations;
using Data.Migrations;
using Data.Models;
using Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Data.ArmsContext
{
    public class ArmsDbContext : IdentityDbContext<Account, IdentityRole<Guid>, Guid>
    {
        public ArmsDbContext(DbContextOptions options) : base(options)
        {
        }
        /// <summary>
        /// Get connection strings in appsetings.json
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("ArmsConnectionString"));
            }
        }
        /// <summary>
        /// Apply db configuration
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CampusConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new StudentProfileConfiguration());
            modelBuilder.ApplyConfiguration(new MajorConfiguration());
            modelBuilder.ApplyConfiguration(new SpecializeMajorConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConsultationConfiguration());
            modelBuilder.ApplyConfiguration(new BannerConfiguration());
            modelBuilder.ApplyConfiguration(new AlumiStudentConfiguration());
            modelBuilder.ApplyConfiguration(new BlogCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new BlogDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new AdmissionPlanConfiguration());
            modelBuilder.ApplyConfiguration(new AdmissionTimeConfiguration());
            modelBuilder.ApplyConfiguration(new TypeOfDiplomaConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());

            modelBuilder.Entity<IdentityUserLogin<Guid>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.ProviderKey });
                entity.HasOne<Account>()
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
                entity.HasOne<Account>()
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne<IdentityRole<Guid>>()
                      .WithMany()
                      .HasForeignKey(e => e.RoleId)
                      .OnDelete(DeleteBehavior.Cascade);

            });
            modelBuilder.Entity<IdentityUserToken<Guid>>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
                entity.HasOne<Account>()
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure IdentityUserClaim
            modelBuilder.Entity<IdentityUserClaim<Guid>>()
                .HasKey(uc => uc.Id);

            modelBuilder.Entity<IdentityUserClaim<Guid>>()
                .HasOne<Account>()
                .WithMany()
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure IdentityRoleClaim
            modelBuilder.Entity<IdentityRoleClaim<Guid>>()
                .HasKey(rc => rc.Id);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>()
                .HasOne<Account>()
                .WithMany()
                .HasForeignKey(rc => rc.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
            // seeding
            new CampusSeeder(modelBuilder).Seed();
            new AccountSeeder(modelBuilder).Seed();
            new MajorSeeder(modelBuilder).Seed();
            new SpecializeMajorSeeder(modelBuilder).Seed();
            new SupplierSeeder(modelBuilder).Seed();
            new StudentConsultationSeeder(modelBuilder).Seed();
            new BlogSeeder(modelBuilder).Seed();
            new CommentSeeder(modelBuilder).Seed();
            new AdmissionPlanSeeder(modelBuilder).Seed();
        }
        #region DbSet
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<SpecializeMajor> SpecializeMajors { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<StudentConsultation> StudentConsultations { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<AlumiStudent> AlumiStudents { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetails> BlogDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AdmissionPlan> AdmissionPlans { get; set; }
        public DbSet<AdmissionTime> AdmissionTimes { get; set; }
        public DbSet<TypeOfDiploma> TypeOfDiplomas { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        #endregion
    }

}
