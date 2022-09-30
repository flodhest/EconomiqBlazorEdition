using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economiq.Shared.Models
{
    public class Budget
    {

        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }   

        public decimal MaxAmount { get; set; }   

        public List<Expense> Expenses { get; set; }

        public User User { get; set; }

        public int? UserNav { get; set; }


    }
}
