using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.LocationSer
{
    public interface ILocationService
    {
        Task<string> GetProvinceName(string provinceCode);
        Task<string> GetDistrictName(string districtCode);
        Task<string> GetWardName(string wardCode);
    }
}
