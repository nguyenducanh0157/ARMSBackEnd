using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.StudentConsultationSer
{
    public class StudentConsultationService : IStudentConsultationService
    {
        private readonly StudentConsultationRepository _studentConsultationRepository;
        public StudentConsultationService(ArmsDbContext context)
        {
            _studentConsultationRepository = new StudentConsultationRepository(context);
        }
        public Task AddNewStudentConsultation(StudentConsultation studentConsultation) => _studentConsultationRepository.AddNewStudentConsultation(studentConsultation);
    }
}
