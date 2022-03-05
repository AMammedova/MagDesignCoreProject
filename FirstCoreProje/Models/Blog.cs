using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreProje.Models
{
    public class Blog:Entity
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public DateTime? Published { get; set; }
        public int BlogStatusId { get; set; }
        public BlogStatus BlogStatus { get; set; }
        public string IpAdress { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
      public ICollection<BlogComment> BlogComments { get; set; }
      public ICollection<BlogLike> BlogLikes { get; set; }

    }
}
