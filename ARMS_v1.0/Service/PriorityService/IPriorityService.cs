﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PriorityService
{
    public interface IPriorityService
    {
        Task<List<PriorityDetail>> GetPriorities();
    }
}
