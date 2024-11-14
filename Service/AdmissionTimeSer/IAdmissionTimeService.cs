﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionTimeSer
{
    public interface IAdmissionTimeService
    {
        Task<List<AdmissionTime>> GetAdmissionTimes(string CampusId);
        Task<AdmissionTime> GetAdmissionTime(int AIId);
        Task AddAdmissionTime(AdmissionTime AdmissionTime);
        Task UpdateAdmissionTime(AdmissionTime AdmissionTime);
    }
}
