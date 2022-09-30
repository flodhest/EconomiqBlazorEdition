using Economiq.Server;
using Economiq.Server.Service;
using Economiq.Shared.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/")]
    [ApiController]
    public class RecipientController : ControllerBase
    {
        private UserService _userService;
        private RecipientService _recipientService;
        public RecipientController(UserService userService, RecipientService recipientService)
        {
            _userService = userService;
            _recipientService = recipientService;
        }
        [HttpPost("createRecipient")]
        public IActionResult CreateRecipient([FromBody] RecipientDTO recipientDTO)
        {
            if (!_userService.DoesUserExist(TempUser.Username))
            {
                return BadRequest("Invalid Username");
            }
            else if (_userService.IsUserLoggedIn(TempUser.Username, TempUser.Password))
            {
                try
                {
                    _recipientService.CreateRecipient(TempUser.Username, recipientDTO.Name, recipientDTO.City, recipientDTO.Street, recipientDTO.Zipcode);
                    return Ok("Recipient Created");
                }

                catch (Exception ex)
                {
                    return StatusCode(500, "Failed To create Recipient");
                }
            }
            else
            {
                return BadRequest("User not logged in");
            }

        }
        [HttpPost("listRecipients")]
        public IActionResult GetRecipients(string? searchString=null)
        {
            if (!_userService.DoesUserExist(TempUser.Username))
            {
                return BadRequest("Invalid Username");
            }
            else if (_userService.IsUserLoggedIn(TempUser.Username, TempUser.Password))
            {
                try
                {
                    var listToReturn = _recipientService.GetRecipients(TempUser.Username, searchString);

                    return StatusCode(200,listToReturn);
                }

                catch (Exception err)
                {
                    return StatusCode(200, "Failed to fetch recipients");
                }
            }
            else
            {
                return BadRequest("User not logged in");
            }

        }


    }
}
