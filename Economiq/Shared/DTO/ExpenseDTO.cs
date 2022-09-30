using System.ComponentModel.DataAnnotations;

namespace Economiq.Shared.DTO
{
    public class ExpenseDTO
    {
        [Required(ErrorMessage = "Expense title required")]
        public string Title { get; set; }
        public string ExpenseDate { get; set; } // Currently needs format "Jan 1, 2009" or "2022-01-28" - Might not be used depending on Johannas opinion on Expense date (customizable to day expense happened or using date expense created in program.
        [Required(ErrorMessage = "Amount required")]
        [Range(1, double.MaxValue, ErrorMessage = "Amount has to be above 0")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Category name required")]
        public string CategoryName { get; set; }
        public string RecipientName { get; set; }
    }
}