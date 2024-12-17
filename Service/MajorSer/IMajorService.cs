﻿using Data.DTO;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.MajorSer
{
    public interface IMajorService
    {

        Task<List<MajorAdmission>> GetMajorsIsCollege(string campusId);
        Task<List<MajorAdmission>> GetMajorsIsVocationalSchool(string campusId);
        Task<MajorAdmission> GetMajorDetail(string MajorID);
        Task AddNewMajor(Major major);
        Task UpdateMajor(Major major);
        Task<List<MajorAdmission>> GetMajorsManage(string campusId);
        Task UpdateMajorAdmission(MajorAdmission Major);
        Task<List<Major>> GetMajors(string campusId);
        Task<MajorAdmission> GetMajorDetail(string MajorID, string campusId);
        Task<Major> GetMajor(string MajorID);
        Task<List<MajorAdmission>> GetMajorsIsCollegeForVocationalSchool(string campusId);
        Task<List<MajorAdmission>> GetMajorAdmissionsByATId(int ATId);
        Task AddMajorAdmision(MajorAdmission major);
        Task<List<object>> GetMajorAdmissionsAndRegisterByATId(int ATId);
        Task<List<object>> GetMajorAdmissionsAndRegisterProcess(string campusId);
        Task<List<object>> ReportAdmission(string campusId);
        Task<List<object>> ReportRegisterAdmission(string campusId);
    }
}
