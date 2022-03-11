using WebApplication1.Models;

namespace WebApplication1.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// get users
        /// </summary>
        /// <returns>return all users</returns>
        Task<List<User>> GetUsersAsync();
    }

    public class UserService : IUserService
    {
        public async Task<List<User>> GetUsersAsync()
        {
            await Task.Delay(2000);//get data from database
            return new List<User>()//data from database
            {
                new User(){Password = "abc",Username = "userFromDB"},
                new User(){Password = "abc",Username = "userFromDB"},
                new User(){Password = "abc",Username = "userFromDB"},
                new User(){Password = "abc",Username = "userFromDB"},
                new User(){Password = "abc",Username = "userFromDB"},
                new User(){Password = "abc",Username = "userFromDB"},
            };
        }
    }

    public class MockUserService : IUserService
    {
        public async Task<List<User>> GetUsersAsync()
        {
            var users = new List<User>()
            {
                new User(){Password = "abc",Username = "userFromMockService"},
                new User(){Password = "abc",Username = "userFromMockService"},
                new User(){Password = "abc",Username = "userFromMockService"},
                new User(){Password = "abc",Username = "userFromMockService"},
                new User(){Password = "abc",Username = "userFromMockService"},
                new User(){Password = "abc",Username = "userFromMockService"},
            };
            return users;
        }
    }
}
