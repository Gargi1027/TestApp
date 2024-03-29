using System.Threading.Tasks;
using TestApp.API.Models;

namespace TestApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register (User user, string password);

         Task<User> Login (string username, string Password);

         Task<bool> UserExists (string username);
    }
}