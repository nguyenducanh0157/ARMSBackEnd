using Data.ArmsContext;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.StudentConsultationRepo
{
    public class StudentConsultationRepository : IStudentConsultationRepository
    {
        private readonly ArmsDbContext _context;
        public StudentConsultationRepository(ArmsDbContext context) { _context = context; }
        public async Task AddNewStudentConsultation(StudentConsultation studentConsultation)
        {
			try
			{
                studentConsultation.Campus = _context.Campuses.SingleOrDefault(x=>x.CampusId.Equals(studentConsultation.CampusId));
                studentConsultation.SpecializeMajor = _context.SpecializeMajors.SingleOrDefault(x => x.SpecializeMajorID.Equals(studentConsultation.SpecializeMajorID));
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
