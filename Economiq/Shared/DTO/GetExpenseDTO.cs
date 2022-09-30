namespace Economiq.Shared.DTO
{
    public class GetExpenseDTO
    {
        public decimal Amount { get; set; }
        public string ExpenseDate { get; set; }
        public string categoryName { get; set; }
        public string? Title { get; set; }
        public string RecipientName { get; set; }
    }
}
