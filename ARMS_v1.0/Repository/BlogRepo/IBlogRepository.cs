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
        Task<List<Blog>> GetBlogs(string CampusId);
        Task<Blog> GetBlog(int BlogId);
        Task<Comment> AddComment(Comment comment);
        Task<bool> CheckFBID(string FacebookUserId);
        Task<Comment> UpdateComment(Comment comment);
        Task<Comment> GetComment(int CommentId);
        Task DeleteComment(int CommentId);
    }
}
