using FirstCoreProje.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreProje.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        
            public virtual  DbSet<User> Users { get; set; }
            public  virtual DbSet<UserStatus> UserStatuses { get; set; }
            public virtual  DbSet<UserRole> UserRoles { get; set; }
            public virtual  DbSet<Blog> Blogs { get; set; }
            public virtual  DbSet<BlogStatus> BlogStatus { get; set; }
            public virtual  DbSet<BlogComment> BlogComments { get; set; }
            public virtual  DbSet<BlogLike> BlogLikes { get; set; }

    }
    
}
