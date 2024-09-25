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

        public async Task<Blog> GetBlog(int BlogId)
        {
            try
            {
                Blog blog = await _context.Blogs
                    .Include(x => x.BlogCategory)
                    .Include(x => x.BlogDetails)
                    .Include(x => x.Comments)
                    .FirstOrDefaultAsync(x=>x.BlogId == BlogId);
                return blog;
            }
            catch (Exception)
            {
                throw;
            }
        }

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

        public async Task<List<Blog>> GetBlogs(string CampusId)
        {
            try
            {
                List<Blog> blogs = await _context.Blogs
                    .Include(x=>x.BlogCategory)
                    .Include(x=>x.BlogDetails)
                    .Include(x => x.Comments)
                    .Where(x => x.BlogCategory.CampusId.Equals(CampusId)).ToListAsync();
                return blogs;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
