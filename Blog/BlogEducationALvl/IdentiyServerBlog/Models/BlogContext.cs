using Microsoft.EntityFrameworkCore;


namespace IdentiyServerBlog.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
