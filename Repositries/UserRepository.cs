using Bloggie.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Repositries
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthDBContext authDBContext;

        public UserRepository(AuthDBContext authDBContext)
        {
            this.authDBContext = authDBContext;
        }
        public async Task<IEnumerable<IdentityUser>> GetAll()
        {
            var users = await authDBContext.Users.ToListAsync();
            var superAdminUser = await authDBContext.Users.FirstOrDefaultAsync(x => x.Email == "superadmin@bloggie.com");

            if (superAdminUser is not null)
            {
                users.Remove(superAdminUser);
            }
            return users;
        }
    }
}
