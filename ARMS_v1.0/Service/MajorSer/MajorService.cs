using Data.ArmsContext;
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

        public async Task<Major> GetMajorDetail(string MajorID)
        {

            return await _majorRepository.GetMajorDetail(MajorID);
        }

        public async Task<List<Major>> GetMajorsIsVocationalSchool(string campusId)
        { 
            var result = await _majorRepository.GetMajors(campusId);
            var activeMajors = result.Where(major => major.isVocationalSchool == true).ToList();
            return activeMajors;
        }
        public async Task<List<Major>> GetMajorsIsCollege(string campusId)
        {
            var result = await _majorRepository.GetMajors(campusId);
            var activeMajors = result.Where(major => major.isVocationalSchool == false).ToList();
            return activeMajors;
        }
    }
}
