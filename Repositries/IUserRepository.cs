using Microsoft.AspNetCore.Identity;

namespace Bloggie.Web.Repositries
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
