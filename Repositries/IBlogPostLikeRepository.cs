using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositries
{
    public interface IBlogPostLikeRepository
    {
        Task<int> GetTotalLikes(Guid BlogPostId);
        Task<IEnumerable<BlogPostLikes>> GetLikesForBlog(Guid blogPostId);
        Task<BlogPostLikes> AddLikeForBlog(BlogPostLikes BlogPostId);
    }
}
