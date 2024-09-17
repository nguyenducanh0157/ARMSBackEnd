using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class LoginDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool? status { get; set; }
        public string? message { get; set; }
    }
}
