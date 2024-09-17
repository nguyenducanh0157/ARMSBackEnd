using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.StudentConsultationRepo
{
    public interface IStudentConsultationRepository
    {
        Task AddNewStudentConsultation(StudentConsultation studentConsultation);
    }
}
