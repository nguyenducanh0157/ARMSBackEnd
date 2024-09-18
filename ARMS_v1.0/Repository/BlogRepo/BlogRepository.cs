using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.BlogRepo
{
    public class BlogRepository: IBlogRepository
    {
        private readonly ArmsDbContext _context;
        public BlogRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<BlogCategory>> GetBlogCategories(string CampusId)
        {
            try
            {
                List<BlogCategory> blogCategories = await _context.BlogCategories.Where(x=>x.CampusId.Equals(CampusId)).ToListAsync();
                return blogCategories;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
