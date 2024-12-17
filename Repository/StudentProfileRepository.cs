using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Repository.StudentProfileRepo
{
    public class StudentProfileRepository 
    {
        private readonly ArmsDbContext _context;
        public StudentProfileRepository(ArmsDbContext context) { _context = context; }
        public async Task<Guid> AddStudentProfile(StudentProfile StudentProfile)
        {
            try
            {
                Guid id = Guid.NewGuid();
                StudentProfile.SpId = id;
                await _context.StudentProfiles.AddRangeAsync(StudentProfile);
                _context.SaveChanges();
                return StudentProfile.SpId;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistCCCDStudent(string CID)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.CitizenIentificationNumber.Equals(CID));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<StudentProfile> GetExistCCCDStudent(string CID)
        {
            try
            {
                var sf = await _context.StudentProfiles
                    .Include(x=>x.AcademicTranscripts)
                    .Include(x=>x.Campus)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV)

                    .Include(x => x.AdmissionTime)
                    .FirstOrDefaultAsync(x => x.CitizenIentificationNumber.Equals(CID));
                
                return sf;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistEmailStudent(string email)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.EmailStudent.ToLower().Equals(email.ToLower()));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistPhoneNumberStudent(string phonenumber)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.PhoneStudent.Equals(phonenumber));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<int> CountAdmissionMajor(string majorId, string CampusId)
        {
            try
            {
                var majorAdmission = await _context.StudentProfiles
                    .Where(x => (x.Major == majorId) && x.CampusId == CampusId
                    && (x.TypeofStatusMajor == TypeofStatusForMajor.Pass && (x.TypeofStatusProfile == TypeofStatus.SuccessProfileAdmission || x.TypeofStatusProfile == TypeofStatus.ConfirmSuccessProfileAdmission || x.TypeofStatusProfile == TypeofStatus.Done)))
                    .ToListAsync();

                return majorAdmission.Count();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<int> CountAdmission(string CampusId)
        {
            try
            {
                var admission = await _context.StudentProfiles
                    .Where(x =>  x.CampusId == CampusId)
                    .ToListAsync();

                return admission.Count();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<int> CountAdmissionsToday(string campusId)
        {
            try
            {
                DateTime today = DateTime.UtcNow.Date;
                int count = await _context.StudentProfiles
                    .Where(x => x.CampusId == campusId && x.TimeRegister.Date == today)
                    .CountAsync();

                return count;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> CountRegisterDone(string CampusId)
        {
            try
            {
                var admission = await _context.StudentProfiles
                    .Where(x => x.CampusId == CampusId && x.TypeofStatusProfile == TypeofStatus.Done)
                    .ToListAsync();

                return admission.Count();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<int> CalculatePassRate(string CampusId)
        {
            try
            {
                var studentProfiles = await _context.StudentProfiles
                    .Where(x => x.CampusId == CampusId)
                    .ToListAsync();

                int totalCount = studentProfiles.Count();

                int passedCount = studentProfiles.Count(x => x.TypeofStatusMajor == TypeofStatusForMajor.Pass);
                int passRate = totalCount > 0 ? (int)((double)passedCount / totalCount * 100) : 0;

                return passRate;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> FindMostSubmittedMajor(string campusId)
        {
            try
            {

                var mostSubmittedMajor = await _context.StudentProfiles
                    .Where(sp => sp.CampusId == campusId) 
                    .Include(x=>x.MajorNV)
                    .GroupBy(sp => sp.Major)
                    .Select(g => new
                    {
                        Major = g.Key,                   
                        Count = g.Count(),
                    })
                    .OrderByDescending(x => x.Count)      
                    .FirstOrDefaultAsync();       

                if (mostSubmittedMajor != null)
                {
                    Major major = await _context.Majors
                    .Include(x => x.Subjects)
                    .SingleOrDefaultAsync(x => x.MajorID.Equals(mostSubmittedMajor.Major));
                    return major.MajorName;    
                }
                else
                {
                    return "No submissions found";  
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<StudentProfile>> GetRegisterAdmission(string CampusId)
        {
            try
            {
                var RegisterAdmission = await _context.StudentProfiles
                    .Include(x=>x.Campus)
                    .Include(x => x.AcademicTranscripts)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV)
                    .Where(x => x.CampusId == CampusId)
                    .OrderByDescending(x => x.PriorityDetailPriorityID)
                    .OrderBy(x => x.TimeRegister)
                    .ToListAsync();

                return RegisterAdmission;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<StudentProfile>> GetRegisterAdmission(int ATId)
        {
            try
            {
                var registerAdmissions = await _context.StudentProfiles
                    .Include(x => x.Campus)
                    .Include(x => x.AcademicTranscripts)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV)
                    .Where(x => x.AdmissionTimeId == ATId)
                    .ToListAsync();

                // Tính tổng điểm dựa trên từng nguyện vọng và điểm ưu tiên
                var sortedAdmissions = registerAdmissions
                    .Select(student =>
                    {
                        // Lấy điểm ưu tiên nếu có
                        var priorityScore = student.PriorityDetail?.TypeOfPriority switch
                        {
                            TypeOfPriority.UT1 => 2,
                            TypeOfPriority.UT2 => 1,
                            _ => 0 // Mặc định nếu không phải UT1 hoặc UT2
                        };

                        // Chỉ tính tổng điểm nếu AcademicTranscripts không null
                        var scoreNV = student.AcademicTranscripts?.Any() == true // Kiểm tra nếu có điểm
                            ? student.AcademicTranscripts.Sum(transcript => transcript.SubjectPoint) + priorityScore
                            : 0; // Nếu không có điểm, tổng là 0

                        return new
                        {
                            Student = student,
                            ScoreNV = scoreNV,
                        };
                    })
                    .OrderByDescending(x => x.ScoreNV) // Sắp xếp giảm dần theo điểm Nguyện vọng 1
                    .ThenBy(x => x.Student.PriorityDetail?.PriorityID ?? int.MaxValue) // Sắp xếp phụ theo độ ưu tiên (ưu tiên null đặt cuối)
                    .ThenBy(x => x.Student.TimeRegister) // Sắp xếp phụ theo thời gian đăng ký
                    .Select(x => x.Student) // Lấy danh sách StudentProfile
                    .ToList();

                return sortedAdmissions;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<StudentProfile?> GetStudentProfileBySpIdAsync(Guid id)
        {
            var studentProfile = await _context.StudentProfiles
                .Include(x => x.Campus)
                    .Include(x => x.AcademicTranscripts)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV)
                    .Include(x => x.AdmissionTime)
                .FirstOrDefaultAsync(x => x.SpId == id);

            return studentProfile;
        }
        public async Task<StudentProfile?> GetStudentProfileBySpCIIdAsync(string id)
        {
            var studentProfile = await _context.StudentProfiles
                .Include(x => x.Campus)
                .Include(x => x.AcademicTranscripts)
                .Include(x => x.PriorityDetail)
                .Include(x=>x.PayFeeAdmissions)
                .Include(x => x.AdmissionTime)
                .FirstOrDefaultAsync(x => x.CitizenIentificationNumber == id);

            return studentProfile;
        }
        //public async Task<StudentProfile> UpdateStudentRegister(StudentProfile StudentProfile)
        //{
        //    try
        //    {
        //        _context.Entry<StudentProfile>(StudentProfile).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //        _context.AcademicTranscripts.RemoveRange(StudentProfile.AcademicTranscripts);
        //        foreach (var transcript in StudentProfile.AcademicTranscripts)
        //        {
        //            StudentProfile.AcademicTranscripts.Add(transcript);
        //        }

        //        await _context.SaveChangesAsync();
        //        return StudentProfile;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        public async Task<StudentProfile> UpdateStudentRegister(StudentProfile studentProfile)
        {
            try
            {
                // Tìm StudentProfile từ cơ sở dữ liệu
                var existingProfile = await _context.StudentProfiles
                    .Include(sp => sp.AcademicTranscripts)
                    .FirstOrDefaultAsync(sp => sp.SpId == studentProfile.SpId);

                if (existingProfile == null)
                {
                    throw new Exception("StudentProfile not found");
                }

                // Cập nhật toàn bộ StudentProfile, Entity Framework sẽ tự động nhận biết sự thay đổi
                _context.Entry(existingProfile).CurrentValues.SetValues(studentProfile);
                _context.AcademicTranscripts.RemoveRange(existingProfile.AcademicTranscripts);

                foreach (var transcript in studentProfile.AcademicTranscripts)
                {
                    _context.AcademicTranscripts.Add(transcript);

                }
                _context.Entry(existingProfile).State = EntityState.Modified;
                // Lưu thay đổi
                await _context.SaveChangesAsync();

                return existingProfile;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
