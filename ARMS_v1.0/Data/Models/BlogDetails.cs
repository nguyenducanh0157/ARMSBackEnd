using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BlogDetails
    {
        public int BDId { get; set; }
        public string? Description { get; set;}
        public string? TitleImg { get; set; }
        public string? Img { get; set; }
        public int BlogId { get; set; }
        public virtual Blog? Blog { get; set; }
    }
}
