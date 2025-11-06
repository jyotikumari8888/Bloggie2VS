using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Repositries
{
    public class BlogPostLikeRepositorycs : IBlogPostLikeRepository
    {
        private readonly BloggieDbContext bloggieDbContext;

        public BlogPostLikeRepositorycs(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        public async Task<int> GetTotalLikes(Guid BlogPostId)
        {
            return await bloggieDbContext.BlogPostLikes
                .CountAsync(x => x.BlogPostId == BlogPostId);
        }

        public async Task<BlogPostLikes> AddLikeForBlog(BlogPostLikes blogPostLikes)
        {
            await bloggieDbContext.BlogPostLikes.AddAsync(blogPostLikes);
            await bloggieDbContext.SaveChangesAsync();
            return blogPostLikes;
        }

        public async Task<IEnumerable<BlogPostLikes>> GetLikesForBlog(Guid blogPostId)
        {
            return await bloggieDbContext.BlogPostLikes.Where(x => x.BlogPostId == blogPostId)
                 .ToListAsync();
        }
    }
}
