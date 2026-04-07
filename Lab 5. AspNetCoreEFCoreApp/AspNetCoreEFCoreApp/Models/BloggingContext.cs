using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEFCoreApp.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
        : base(options)
        { }

        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Post>? Authors { get; set; }
        public DbSet<PostAuthor> PostAuthors { get; set; }
    }
}
