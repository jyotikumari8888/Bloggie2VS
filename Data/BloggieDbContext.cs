using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Bloggie.Web.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions<BloggieDbContext> Options) : base(Options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //public DbSet<BlogPostLike> BlogPostLikes { get; set; }

        public DbSet<BlogPostLikes> BlogPostLikes { get; set; }

        public DbSet<BlogPostComments> BlogPostComments { get; set; }

    }
}
