using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Comment
    {
        public int CommentId { get; set; } // Primary key
        public string Content { get; set; } // Comment content
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Comment creation date

        public int BlogId { get; set; } // The blog post ID this comment belongs to
        public string FacebookUserId { get; set; } // ID user Facebook
        public string? FacebookUserName { get; set; } // User name FB Facebook

        public int? ParentCommentId { get; set; } // Nullable, parent comment ID if reply
        public virtual Comment? ParentComment { get; set; } // Reference to parent comment if any
        public virtual ICollection<Comment>? Replies { get; set; } // List replies

        public virtual Blog Blog { get; set; }
    }
}
