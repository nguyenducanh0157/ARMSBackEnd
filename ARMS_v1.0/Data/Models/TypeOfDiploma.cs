using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public enum TypeOfDiploma
    {
        TotNghiepTHCS_HocLop10_11_12,   // Tốt nghiệp THCS, học lớp 10, 11, 12
        Hoc2Nam_TotNghiepTHPT,          // Học 2 năm, Tốt nghiệp THPT hoặc bổ túc THPT
        Hoc1Den1_5Nam_TotNghiepTHCS,    // Học 1 năm đến 1,5 năm, Tốt nghiệp THCS
        TotNghiepDaiHoc_CaoDang_TrungCap_Hoc1Nam // Tốt nghiệp Đại học, Cao đẳng, Trung cấp - Học 1 năm
    }
}
