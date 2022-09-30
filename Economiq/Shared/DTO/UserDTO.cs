namespace Economiq.Shared.DTO
{
    public class UserDTO
    {

        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Username { get; set; }
        public string email { get; set; }
        public string password { get; set; } //This way of authing should in no way shape or form be allowed to persist to release. 
        public string Gender { get; set; }
        public string City { get; set; }

    }

}
