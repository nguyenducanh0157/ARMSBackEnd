using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class CommentDTO
    {
        public int CommentId { get; set; } // Primary key
        public string Content { get; set; } // Comment content
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Comment creation date
        public string FacebookUserId { get; set; } // ID user Facebook
        public string? FacebookUserName { get; set; } // User name FB Facebook
        public int? ParentCommentId { get; set; } // Nullable, parent comment ID if reply
    }
}
