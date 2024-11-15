using Data.ArmsContext;
using Data.DTO;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.MajorSer
{
    public class MajorService : IMajorService
    {
        private readonly MajorRepository _majorRepository;
        public MajorService(ArmsDbContext context)
        {
            _majorRepository = new MajorRepository(context);
        }

        //public async Task<Major> GetMajorDetail(string MajorID)
        //{

        //    return await _majorRepository.GetMajorDetail(MajorID);
        //}
        public async Task<List<MajorAdmission>> GetMajorsIsVocationalSchool(string campusId)
        {
            var result = await _majorRepository.GetMajorAdmissions(campusId);
            var activeMajors = result.Where(major => major.Major.isVocationalSchool == true).ToList();
            return activeMajors;
        }
        public async Task<List<MajorAdmission>> GetMajorsIsCollege(string campusId)
        {
            var result = await _majorRepository.GetMajorAdmissions(campusId);
            var activeMajors = result.Where(major => major.Major.isVocationalSchool == false).ToList();
            return activeMajors;
        }

        public async Task AddNewMajor(Major major)
        {
            //major.Status = false;
            await _majorRepository.AddNewMajor(major);
        }

        public async Task UpdateMajor(Major major)=> await _majorRepository.UpdateMajor(major);

        public async Task<List<Major>> GetMajorsAdmin(string campusId)=> await _majorRepository.GetMajors_Manage(campusId);

        //public async Task UpdateMajorAdmission(Major Major)
        //{
        //    var majorValid = await _majorRepository.GetMajorDetail(Major.MajorID);
        //    if (majorValid == null) throw new Exception("Không tồn tại ngành học");
        //    //majorValid.Status = Major.Status;
        //    //majorValid.Target = Major.Target;
        //    majorValid.TypeAdmissions = Major.TypeAdmissions;
        //    await _majorRepository.UpdateMajor(majorValid);
        //}

        public Task<MajorAdmission> GetMajorDetail(string MajorID, int AdmissionInformationID)
            => _majorRepository.GetMajorDetail(MajorID, AdmissionInformationID);

        public Task<Major> GetMajorDetail(string MajorID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMajorAdmission(Major Major)
        {
            throw new NotImplementedException();
        }
    }
}
