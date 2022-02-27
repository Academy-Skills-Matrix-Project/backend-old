using System.IO;

namespace SkillsMatrixAPI.Repositories
{
    public interface IUserRepository
    {
        string GetAllUsers();
    }

    public class UserRepository : IUserRepository
    {
        private string GetAllUsersFromFile()
        {
            string fileName = "Repositories/MOCK_USER_DATA.json";
            StreamReader reader = new(fileName);
            string allUsers = reader.ReadToEnd();
            return allUsers;
        }
        public string GetAllUsers()
        {
            var allUsers = GetAllUsersFromFile();
            return allUsers;
        }
    }
}
