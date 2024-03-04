using AnonymousForum.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AnonymousForum.Data
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options) : base(options) { }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<ForumThread> ForumThreads { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }

}
