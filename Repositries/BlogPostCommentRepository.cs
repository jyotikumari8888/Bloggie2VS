using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Repositries
{
    public class BlogPostCommentRepository : IBlogPostCommentRepository
    {
        private readonly BloggieDbContext bloggieDbContext;

        public BlogPostCommentRepository(BloggieDbContext bloggieDbContext)

        {
            this.bloggieDbContext = bloggieDbContext;
        }
        public async Task<BlogPostComments> Addasync(BlogPostComments blogPostComment)
        {
            await bloggieDbContext.BlogPostComments.AddAsync(blogPostComment);
            await bloggieDbContext.SaveChangesAsync();
            return blogPostComment;
        }

        public async Task<IEnumerable<BlogPostComments>> GetCommentBlogIdAsync(Guid blogPostId)
        {
            return await bloggieDbContext.BlogPostComments.Where(x => x.BlogPostId == blogPostId)
                 .ToListAsync();
        }
    }
}
