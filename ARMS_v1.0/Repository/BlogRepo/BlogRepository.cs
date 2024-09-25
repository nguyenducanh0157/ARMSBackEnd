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
        public async Task<Comment> AddComment(Comment comment)
        {
            try
            {
                await _context.Comments.AddAsync(comment);
                _context.SaveChanges();
                return comment;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Comment> UpdateComment(Comment comment)
        {
            try
            {
                _context.Entry<Comment>(comment).State = EntityState.Modified;
                _context.SaveChanges();
                return comment;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Comment> GetComment(int CommentId)
        {
            try
            {
                var comment = await _context.Comments.SingleOrDefaultAsync(x=>x.CommentId==CommentId);
                return comment;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteComment(int CommentId)
        {
            try
            {
               var comment = _context.Comments.Include(x=>x.Replies).SingleOrDefault(x=>x.CommentId==CommentId);
                _context.Comments.RemoveRange(comment.Replies);
                _context.Comments.Remove(comment);
                _context.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CheckFBID(string FacebookUserId)
        {
            try
            {
                var comment = await _context.Comments.SingleOrDefaultAsync(x=>x.FacebookUserId.Equals(FacebookUserId));
                if (comment != null) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
