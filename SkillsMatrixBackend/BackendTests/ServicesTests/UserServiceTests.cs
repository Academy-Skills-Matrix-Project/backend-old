using NUnit.Framework;
using SkillsMatrixAPI.Services;
using SkillsMatrixAPI.Repositories;
using SkillsMatrixAPI;
using System.Collections.Generic;

namespace BackendTests.ServicesTests
{
    public class UserServiceTests
    {
        
        [Test]
        public void ListAllUsers_Should_ReturnAllUsersAsList()
        {
            //Arrange
            UserRepository userRepository = new();
            UserService userService = new(userRepository);

            //Act
            List<User> listOfUsers = userService.ListAllUsers();

            //Assert
            Assert.IsInstanceOf<List<User>>(listOfUsers);
            Assert.AreEqual(10, listOfUsers.Count);
            
        }
    }
}