using NUnit.Framework;
using SkillsMatrixAPI;
using SkillsMatrixAPI.Services;
using SkillsMatrixAPI.Controllers;
using SkillsMatrixAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BackendTests
{

    [TestFixture]
    public class UserControllerTests
    {
        
        [SetUp]
        public void Setup()
        {

        }
        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void GetUsers_Should_ReturnHTTP200WithJson()
        {
            //https://stackoverflow.com/questions/51489111/how-to-unit-test-with-actionresultt
            //" As stated in other answers, ActionResult<T> has either its Result or Value property set but not both. When you return an OkObjectResult the framework populates the Result property. When you return an object the framework populates the Value property "

            //Arrange
            UserRepository userRepository = new();
            UserService userService = new(userRepository);
            UserController userController = new(userService);

            //Act
            ActionResult<List<User>> actionResult = userController.GetUsers();
            OkObjectResult okObjResult = actionResult.Result as OkObjectResult;
            List<User> okObjValue = okObjResult.Value as List<User>;

            // Assert
            Assert.NotNull(actionResult);
            Assert.NotNull(okObjResult);
            Assert.AreEqual(200, okObjResult.StatusCode);
            Assert.AreEqual(10, okObjValue.Count);
            Assert.IsInstanceOf<OkObjectResult>(actionResult.Result);
            Assert.IsInstanceOf<List<User>>(okObjValue);
            Assert.IsInstanceOf<User>(okObjValue[1]);
        }
    }
}