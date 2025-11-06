using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositries
{
    public interface IBlogPostCommentRepository
    {
        Task<BlogPostComments> Addasync(BlogPostComments blogPostComment);
        Task<IEnumerable<BlogPostComments>> GetCommentBlogIdAsync(Guid blogPostId);
    }
}
