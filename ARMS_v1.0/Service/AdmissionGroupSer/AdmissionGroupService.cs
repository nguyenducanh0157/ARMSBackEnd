﻿using Data.ArmsContext;
using Data.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionGroupSer
{
    public class AdmissionGroupService : IAdmissionGroupService
    {
        private readonly AdmissionGroupRepository _admissionGroupRepository;
        public AdmissionGroupService(ArmsDbContext context)
        {
            _admissionGroupRepository = new AdmissionGroupRepository(context);
        }
        public Task<List<AdmissionGroup>> GetAdmissionGroupScoreAcademicAsync(string campusId) 
            => _admissionGroupRepository.GetAdmissionGroupScoreAcademicAsync(campusId);

        public Task<List<AdmissionGroup>> GetAdmissionGroupScroreAsync(string campusId)
            => _admissionGroupRepository.GetAdmissionGroupScroreAsync(campusId);
    }
}