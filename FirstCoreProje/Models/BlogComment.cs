using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreProje.Models
{
    public class BlogComment:Entity
    {
        public int UserId { get; set; }
        public string Text { get; set; }
        public int BlogCommentStatusId { get; set; }
        public BlogCommentStatus BlogCommentStatus { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
