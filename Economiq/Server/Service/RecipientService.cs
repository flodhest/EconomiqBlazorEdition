using Economiq.Server.Data;
using Economiq.Shared.DTO;
using Economiq.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Economiq.Server.Service
{
    public class RecipientService
    {
        private readonly EconomiqContext _context;
        public RecipientService(EconomiqContext context)
        {
            _context = context;
        }
        public bool CreateRecipient(string userName, string recipientName, string recipientCity, string recipientStreet, string recipientZipcode)
        {
            var user = _context.Users.Where(user => user.UserName == userName).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("No user with this username.");
            }
            var newRecipient = new Recipient
            {
                Name = recipientName,
                City = recipientCity,
                Street = recipientStreet,
                Zipcode = recipientZipcode
            };

            if (user.RecipientNav == null)
            {
                user.RecipientNav = new List<Recipient> { newRecipient };
            }

            user.RecipientNav.Add(newRecipient);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false; 
            }
        }
        public List<RecipientDTO> GetRecipients(string Username, string? SearchString = null)
        {
            List<RecipientDTO> listToReturn = new List<RecipientDTO>();

            var user = _context.Users.Include(e => e.RecipientNav).FirstOrDefault(x => x.UserName == Username);
            var recipients = user.RecipientNav.ToList();

            foreach (var recipient in recipients)
            {
                if (SearchString == null)
                {
                    listToReturn.Add(new RecipientDTO { Id = recipient.Id, Name = recipient.Name, City = recipient.City, Street=recipient.Street, Zipcode=recipient.Zipcode });
                }
                else if (recipient.Name.ToLower().StartsWith(SearchString.ToLower()))
                {
                    listToReturn.Add(new RecipientDTO { Id = recipient.Id, Name = recipient.Name, City = recipient.City, Street=recipient.Street, Zipcode=recipient.Zipcode });
                }
            }
            return listToReturn;
        }

    }
}