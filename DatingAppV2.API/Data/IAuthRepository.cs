using System.Threading.Tasks;
using DatingAppV2.API.Model;

namespace DatingAppV2.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);

    }
}