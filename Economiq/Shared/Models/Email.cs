namespace Economiq.Shared.Models
{
    public class Email
    {
        int Id { get; set; }
        [System.ComponentModel.DataAnnotations.EmailAddress]
        public String Mail { get; set; }

        //Navigational Properties
        public User UserNav { get; set; }
        public int UserNavId { get; set; }
    }
}
