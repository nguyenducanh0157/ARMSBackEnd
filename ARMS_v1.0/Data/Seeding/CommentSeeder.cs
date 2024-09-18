using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class CommentSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public CommentSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            //seed banner 
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    Content = "This is the first comment",
                    CreatedDate = DateTime.Now,
                    BlogId = 1,
                    FacebookUserId = "fb12345",
                    FacebookUserName = "John Doe",
                    ParentCommentId = null
                },
                new Comment
                {
                    CommentId = 2,
                    Content = "This is a reply to the first comment",
                    CreatedDate = DateTime.Now,
                    BlogId = 1,
                    FacebookUserId = "fb67890",
                    FacebookUserName = "Jane Smith",
                    ParentCommentId = 1
                },
                new Comment
                {
                    CommentId = 3,
                    Content = "Another comment on the second blog",
                    CreatedDate = DateTime.Now,
                    BlogId = 2,
                    FacebookUserId = "fb54321",
                    FacebookUserName = "Alice",
                    ParentCommentId = null 
                }
                );
        }
    }
}
