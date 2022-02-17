using NUnit.Framework;
using SkillsMatrixAPI.Services;

namespace BackendTests
{
    public class UserControllerTests
    {
        private readonly IUserService _service;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_ReturnUserById_When_GetUserByIdInvoked()
        {
            var Service = new Mock<IService>();
            Assert.Pass();
        }
    }
}