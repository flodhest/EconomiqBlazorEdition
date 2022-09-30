using Economiq.Server;
using Economiq.Server.Service;
using Economiq.Shared.DTO;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _us;

        public UserController(UserService userService)
        {
            _us = userService;
        }

        [HttpPost("createUser")]
        public IActionResult CreateUser([FromBody] UserDTO userDTO)
        {
            try
            {
                _us.RegisterUser(userDTO);
                return Ok(userDTO);
            }

            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        [HttpPost("login")]
        public IActionResult LoginUser()
        {
            if (!_us.DoesUserExist(TempUser.Username))
            {
                return BadRequest("Invalid Username");
            }
            else
            {
                _us.LoginUser(TempUser.Username, TempUser.Password);
                return Ok("User Logged In");
            }
        }
        [HttpPost("logout")]
        public IActionResult LogoutUser()
        {
            if (!_us.DoesUserExist(TempUser.Username))
            {
                return BadRequest("Invalid Username");
            }
            try
            {
                _us.LogoutUser(TempUser.Username, TempUser.Password);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
            return Ok("User logged out");
        }
        
        
    }
}

