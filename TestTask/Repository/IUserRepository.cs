using System.Collections.Generic;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserAsync(int id);
        
        Task UpdateUserAsync(User user);
    }
}