using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BlogRepo
{
    public interface IBlogRepository
    {
        Task<List<BlogCategory>> GetBlogCategories(string CampusId);
    }
}
