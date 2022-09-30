using System.ComponentModel.DataAnnotations;

namespace Economiq.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } //Is this really needed if using jwt authentication? 
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        //Navigational Properties
        //For Expense
        public List<Expense>? UserExpensesNav { get; set; }
        //For ExpenseCategory
        public List<ExpenseCategory>? ExpensesCategoryNav { get; set; }
        //Email
        public List<Email> Emails { get; set; }
        public bool IsLoggedIn { get; set; }
        //For recipients
        public List<Recipient>? RecipientNav { get; set; }

        public List<Budget> Budgets { get; set; }
    }
}
