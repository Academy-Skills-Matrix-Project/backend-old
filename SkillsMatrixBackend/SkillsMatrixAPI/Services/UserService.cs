using SkillsMatrixAPI.Repositories;
using System.Collections.Generic;
using System.Text.Json;


namespace SkillsMatrixAPI.Services
{
    
    public interface IUserService
    {
        List<User> ListAllUsers();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
       
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> ListAllUsers()
        {
            string allUsersString = _userRepository.GetAllUsers();
            List<User> allUsersList = JsonSerializer.Deserialize<List<User>>(allUsersString);
            return allUsersList;
        }
    }
}