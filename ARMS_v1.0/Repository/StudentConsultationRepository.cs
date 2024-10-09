using Data.ArmsContext;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentConsultationRepository
    {
        private readonly ArmsDbContext _context;
        public StudentConsultationRepository(ArmsDbContext context) { _context = context; }
        public async Task AddNewStudentConsultation(StudentConsultation studentConsultation)
        {
            try
            {
                studentConsultation.Campus = _context.Campuses.FirstOrDefault(x=>x.CampusId==studentConsultation.CampusId);
                studentConsultation.Major = _context.Majors.FirstOrDefault(x => x.MajorID == studentConsultation.MajorID);
                await _context.StudentConsultations.AddAsync(studentConsultation);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Đăng ký không thành công");
            }
        }
    }
}
