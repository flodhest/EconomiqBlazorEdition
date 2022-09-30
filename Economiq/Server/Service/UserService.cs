using Economiq.Server.Data;
using Economiq.Shared.DTO;
using Economiq.Shared.Models;

namespace Economiq.Server.Service
{
    public class UserService
    {
        private ExpenseCategoryService _categoryService;
        private GetExpenseDTO _expenseDTO;
        private readonly EconomiqContext _context;

        public UserService(EconomiqContext context, ExpenseCategoryService categoryService)
        {
            _context = context;
            _categoryService = categoryService;
            _expenseDTO = new GetExpenseDTO();
        }

        private int _minimumPasswordLength = 8;
        private bool IsPasswordOk(string password)
        {
            return password.Length >= _minimumPasswordLength;
        }
        public void RegisterUser(UserDTO newUser)
        {
            if (!IsPasswordOk(newUser.password))
            {
                throw new Exception("Password is too weak");
            }
            if (_context.Users.Where(user => user.UserName.ToLower() == newUser.Username.ToLower()).Count() > 0)
            {
                throw new Exception("Username allready exists");
            }
            var email = new Email
            {
                Mail = newUser.email
            };
            var Emails = new List<Email>();
            Emails.Add(email);
            _context.Users.Add(new User
            {
                Fname = newUser.Fname,
                Lname = newUser.Lname,
                UserName = newUser.Username,
                Password = newUser.password,
                Emails = Emails,
                IsLoggedIn = false,
                CreationDate = DateTime.Now,
                City = newUser.City,
                Gender = newUser.Gender
            });
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            _categoryService.CreateExpenseCategory(newUser.Username, "Rent");
            _categoryService.CreateExpenseCategory(newUser.Username, "Food");
            _categoryService.CreateExpenseCategory(newUser.Username, "Transport");
            _categoryService.CreateExpenseCategory(newUser.Username, "Clothing");
            _categoryService.CreateExpenseCategory(newUser.Username, "Entertainment");
        }
        public bool LoginUser(string userName, string password)
        {
            var user = _context.Users.Where(user => user.UserName == userName).FirstOrDefault();
            if (user is null)
            {
                throw new Exception("Invalid Username");
            }

            if (user.UserName == userName && user.Password == password)
            {
                try
                {
                    user.IsLoggedIn = true;
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                throw new Exception("Invalid username or password");
            }

            return true;
        }
        public bool DoesPasswordMatch(string username, string password)
        {
            var user = _context.Users.Where(user => user.UserName == username).FirstOrDefault();
            return (user.Password == password);
        }


        public bool LogoutUser(string userName, string password)
        {
            var user = _context.Users.Where(user => user.UserName == userName).FirstOrDefault();
            if (user is null)
            {
                throw new Exception("Invalid username");
            }
            else if (!IsUserLoggedIn(userName, password))
            {
                throw new Exception("User not logged in");
            }
            else
            {
                user.IsLoggedIn = false;
                _context.SaveChanges();
            }
            return true;
        }
        public bool IsUserLoggedIn(string userName, string password)
        {
            var user = _context.Users.Where(user => user.UserName == userName).FirstOrDefault();
            if (user == null)
            {
                return false;
            }
            else if (user.UserName == userName && user.Password == password)
            {
                return user.IsLoggedIn;
            }
            else
            {
                return false;
            }

        }
        public bool DoesUserExist(string userName)
        {
            return (_context.Users.Where(user => user.UserName == userName) != null);
        }
    }
}
