namespace Economiq.Shared.Models
{
    public class Recipient
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Street { get; set; } = String.Empty!;
        public string Zipcode { get; set; } = String.Empty!;
        public string City { get; set; } = String.Empty!;
        

        //Nav properties

        //For User
        public int UserNavId { get; set; }
        public User? UserNav { get; set; }
        //For Expense
        public List<Expense>? ExpenseNav { get; set; }




    }
}