using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public ActionResult Register(UserForRegister userForRegister)
        {
            var userToRegister = _userService.Register(userForRegister);
            if (userToRegister)
            {
                return Ok(userToRegister);

            }

            return BadRequest("Registeration Failed");
        }


        [HttpPost("login")]
        public ActionResult Login(UserForLogin userForLogin)
        {
            var userToLogin = _userService.Login(userForLogin);
            if (userToLogin == null)
            {
                return BadRequest("User not found");
            }

            return Ok(userToLogin);
        }

    }
}
