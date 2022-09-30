using Economiq.Server.Data;
using Economiq.Shared.DTO;
using Economiq.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Economiq.Server.Service
{
    public class ExpenseService
    {
        private ExpenseCategoryService _expenseCategoryService;
        private readonly EconomiqContext _context;
        private readonly BudgetService _budgetService;
        public ExpenseService(EconomiqContext context, ExpenseCategoryService expenseCategoryService, BudgetService budgetService)
        {
            _expenseCategoryService = expenseCategoryService;
            _context = context;
            _budgetService = budgetService;
        }


        public async Task<bool> AddExpense(ExpenseDTO expense, string userName)
        {

            //Gets the user by username
            var user = _context.Users.Where(user => user.UserName == userName).Include(r => r.RecipientNav).Include(u=>u.UserExpensesNav).FirstOrDefault();
            var recipient = user.RecipientNav.Where(rec => rec.Name == expense.RecipientName).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("No User with this Username.");
            }
            //Gets the category the expense belongs to, or creates one if it doesnt exist.
            var category = _context.ExpensesCategory.Where(c => c.CategoryName.ToLower() == expense.CategoryName.ToLower()).FirstOrDefault();
            if (category == null)
            {
                try
                {
                    _expenseCategoryService.CreateExpenseCategory(userName, expense.CategoryName);
                    category = _context.ExpensesCategory.Where(c => c.CategoryName.ToLower() == expense.CategoryName.ToLower()).FirstOrDefault();
                }
                catch
                {
                    throw new Exception("Could not create missing Category");
                }
            }
            //Length Check for title/comment
            if (expense.Title.Length > 50)
            {
                throw new Exception("Title Too Long (Needs to be less than 50 characters)");
            }
            //Creates the expense and adds it to the user (creates list ifs the first expense on the user)
            DateTime expenseDate = DateTime.Parse(expense.ExpenseDate).Date;
            DateTime creationDate = DateTime.Now;
            var newExpense = new Expense { Amount = expense.Amount, CreationDate = creationDate, ExpenseDate = expenseDate, Comment = expense.Title, UserNavId = user.Id, CategoryNavId = category.Id, RecipientNavId = recipient.Id };

            if (user.UserExpensesNav == null)
            {
                user.UserExpensesNav = new List<Expense>();
            }
            CreateBudgetDTO newBudget = new() //Needed to get relevant budget from budget service 
            {
                ExpenseDate = expense.ExpenseDate
            };
            ListBudgetDTO relevantBudget = await _budgetService.GetBudgetByDate(newBudget, TempUser.Id);
            if (relevantBudget == null) //Unhappy Scenario, no budget for time period exists
            {
                var newBudgetMaxAmount = await _budgetService.GetLatestMaxAmount(Economiq.Server.TempUser.Id);
                CreateBudgetDTO createBudgetDTO = new()
                {
                    MaxAmount = newBudgetMaxAmount,
                    ExpenseDate = expense.ExpenseDate
                };
                await _budgetService.CreateBudget(createBudgetDTO, Economiq.Server.TempUser.Id);
            }
            relevantBudget = await _budgetService.GetBudgetByDate(newBudget, Economiq.Server.TempUser.Id);     
            newExpense.BudgetNav = relevantBudget.Id;
            
            try
              {
                user.UserExpensesNav.Add(newExpense);
                await _context.SaveChangesAsync();
                    return true;
              }
                catch
                {
                    throw new Exception("Something went wrong");
                }
            
        }

        public List<GetExpenseDTO> GetAllExpensesByUsername(string Username)
        {
            List<GetExpenseDTO> listToReturn = new List<GetExpenseDTO>();

                var user = _context.Users.Include(e => e.UserExpensesNav).ThenInclude(e=>e.CategoryNav).Include(e => e.RecipientNav).FirstOrDefault(x => x.UserName == Username);
                var expenses = user.UserExpensesNav.ToList();


                foreach (var expense in expenses)
                {
                    listToReturn.Add(new GetExpenseDTO { Amount = expense.Amount, Title = expense.Comment, ExpenseDate = expense.ExpenseDate.ToString("dd/MM/yyyy"), categoryName = expense.CategoryNav.CategoryName, RecipientName = expense.RecipientNav.Name }) ;

                }
                return listToReturn;
            
        }

        public async Task<List<GetExpenseDTO>> GetRecentExpenses(string username)
        {
            List<GetExpenseDTO> recentExpenses = new();

            User? user = await _context.Users
                .Include(e => e.UserExpensesNav)
                .ThenInclude(e => e.CategoryNav)
                .Include(e => e.RecipientNav)
                .FirstOrDefaultAsync(x => x.UserName == username);
            List<Expense>? expenses = user.UserExpensesNav
                .OrderByDescending(x => x.CreationDate)
                .Take(5)
                .ToList();

            if(user.RecipientNav.Count != 0){ 
                foreach (var expense in expenses)
                {
                    recentExpenses.Add(new GetExpenseDTO { Amount = expense.Amount, Title = expense.Comment, ExpenseDate = expense.ExpenseDate.ToString("dd/MM/yyyy"), categoryName = expense.CategoryNav.CategoryName, RecipientName = expense.RecipientNav.Name });
                }
                return recentExpenses;
            }
            return new();
            
        }
    }
}
