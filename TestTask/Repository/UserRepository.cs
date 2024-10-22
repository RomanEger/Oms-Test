using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using TestTask.Models;

namespace TestTask.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        
        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "exec SelectFIO";
                var users = await connection.QueryAsync<User>(query);
                return users;
            }
        }

        public async Task<User> GetUserAsync(int id)
        {
            var users = await GetUsersAsync();
            return users.FirstOrDefault(x => x.Id == id);
        }
        
        public async Task UpdateUserAsync(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = $"exec UpdateFIO {user.Id}, '{user.LastName}', '{user.FirstName}', '{user.Patronymic}'";
                await connection.ExecuteAsync(query);
            }
        }
    }
}