using Microsoft.AspNetCore.Mvc;
using SkillsMatrixAPI.Services;

namespace SkillsMatrixAPI.Controllers
{

    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            return Ok(_userService.ListAllUsers());
        }
    }
}
