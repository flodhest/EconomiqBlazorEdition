using Economiq.Server;
using Economiq.Server.Service;
using Economiq.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private UserService _userService;
        private ExpenseService _expenseService;
       
        public ExpenseController(ExpenseService expenseService, UserService userService)
        {
            _expenseService = expenseService;
            _userService = userService;
            
        }

        [HttpPost("createExpense")]
        public async Task<IActionResult> CreateExpense([FromBody] ExpenseDTO expenseDTO)
        {
            if (!_userService.DoesUserExist(TempUser.Username))
            {
                return BadRequest("Invalid Username");
            }

            else if (_userService.IsUserLoggedIn(TempUser.Username, TempUser.Password))
            {
                try
                {
                    await _expenseService.AddExpense(expenseDTO, TempUser.Username);
                    return StatusCode(200, "Expense Successfully Created");
                }

                catch (Exception err)
                {
                    return StatusCode(500, "Failed to create Expense");
                }
            }
            else
            {
                return BadRequest("User not logged in");
            }

        }

        [HttpGet("listExpense")]
        public IActionResult GetExpenses()
        {
            if (!_userService.DoesUserExist(TempUser.Username))
            {
                return BadRequest("Invalid Username");
            }
            else if (_userService.IsUserLoggedIn(TempUser.Username, TempUser.Password))
            {
                try
                {
                    List<GetExpenseDTO> listToReturn = _expenseService.GetAllExpensesByUsername(TempUser.Username);
                    return StatusCode(200, listToReturn);
                }

                catch (Exception err)
                {
                    return StatusCode(500, "Could not fetch Expenses");
                }
            }
            else
            {
                return BadRequest("User not logged in");
            }
        }

        [HttpGet("getRecent")]
        public async Task<IActionResult> GetRecentExpenses()
        {
            if (_userService.IsUserLoggedIn(TempUser.Username, TempUser.Password))
            {
                try
                {
                    List<GetExpenseDTO> recentExpenses = await _expenseService.GetRecentExpenses(TempUser.Username);
                    return StatusCode(200, recentExpenses);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, "Failed to fetch recent Expenses");
                }
            }
            else
            {
                return BadRequest("User not logged in");
            }
        }
    }
}
