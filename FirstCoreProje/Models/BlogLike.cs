using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreProje.Models
{
    public class BlogLike:Entity
    {
        public int UserId { get; set; }
        public int BlogId { get; set; }
        public User User { get; set; }
        public Blog Blog { get; set; }
    }
}
