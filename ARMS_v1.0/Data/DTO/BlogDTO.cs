using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class BlogDTO
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public BlogCategoryDTO? BlogCategory { get; set; }
        public virtual ICollection<BlogDetailsDTO>? BlogDetails { get; set; }
        public virtual ICollection<CommentDTO>? Comments { get; set; }
    }
}
