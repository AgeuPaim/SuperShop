using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;


namespace SuperShop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmail(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
