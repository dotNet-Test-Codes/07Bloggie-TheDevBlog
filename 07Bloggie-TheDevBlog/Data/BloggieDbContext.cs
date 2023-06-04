using _07Bloggie_TheDevBlog.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace _07Bloggie_TheDevBlog.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
