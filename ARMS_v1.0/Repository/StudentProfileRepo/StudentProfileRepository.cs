﻿using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.StudentProfileRepo
{
    public class StudentProfileRepository : IStudentProfileRepository
    {
        private readonly ArmsDbContext _context;
        public StudentProfileRepository(ArmsDbContext context) { _context = context; }
        public async Task AddStudentProfile(StudentProfile StudentProfile)
        {
			try
			{
                Guid id = Guid.NewGuid();
                var TypeOfDiploma = await _context.TypeOfDiplomas.SingleOrDefaultAsync(x=>x.DiplomaId== StudentProfile.DiplomaId);
                var campus = await _context.Campuses.SingleOrDefaultAsync(x=>x.CampusId == StudentProfile.CampusId);
                StudentProfile.TypeOfDiploma = TypeOfDiploma;
                StudentProfile.Campus = campus;
                StudentProfile.SpId = id;
                await _context.StudentProfiles.AddAsync(StudentProfile);
                _context.SaveChanges();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
