using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AdmissionPlanRepo
{
    public interface IAdmissionPlanRepository
    {
        Task<AdmissionPlan> GetAdmissionPlan(string CampusId);
    }
}
