using System.ComponentModel.DataAnnotations;

namespace Economiq.Shared.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public DateTime CreationDate { get; set; }



        public string? Comment { get; set; }
        //Navigational Properites
        //For User Relation
        public int UserNavId { get; set; }
        public User? UserNav { get; set; }
        //For Category
        public int? CategoryNavId;
        public ExpenseCategory? CategoryNav { get; set; }
        //For Recipient
        public int? RecipientNavId { get; set; }
        public Recipient? RecipientNav { get; set; }

        public Budget? Budget { get; set; }

        public Guid? BudgetNav { get; set; }
    }
}
