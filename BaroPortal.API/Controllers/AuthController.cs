using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Authorization;
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



        [HttpGet("Profile{id}"), Authorize]
        public async Task<ActionResult<UserForRegister>> GetSingleHero(int id)
        {
            var result = await _userService.GetSingleHero(id);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
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




        [HttpPost("forgotMyPassword")]
        public ActionResult ForgotMyPassword(ForgotMyPasswordDto forgotMyPasswordDto)
        {
            var userToLogin = _userService.ForgotMyPassword(forgotMyPasswordDto);
            if (userToLogin == null)
            {
                return BadRequest("Login Failed");
            }

            return Ok(userToLogin);
        }



    }
 
}
