using System.ComponentModel.DataAnnotations;

namespace Economiq.Shared.DTO
{
    public class RecipientDTO
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "Recipient Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Recipient City Required")]
        public string City { get; set; }

        public string Street { get; set; }
        public string Zipcode { get; set; }
    }
}
