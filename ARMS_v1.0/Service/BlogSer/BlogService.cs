﻿using Data.ArmsContext;
using Data.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BlogSer
{
    public class BlogService : IBlogService
    {
        private readonly BlogRepository _blogRepository;
        public BlogService(ArmsDbContext context)
        {
            _blogRepository = new BlogRepository(context);
        }
        public async Task<Blog> GetBlog(int BlogId) => await _blogRepository.GetBlog(BlogId);

        public async Task<List<BlogCategory>> GetBlogCategories(string CampusId) => await _blogRepository.GetBlogCategories(CampusId);

        public async Task<List<Blog>> GetBlogs(string CampusId) => await _blogRepository.GetBlogs(CampusId);
    }
}
