using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public class BankAccount
    {
        [Key]
        public int AccountId { get; set; }

        public string AccountName { get; set; }

        public string AccountDescription { get; set; }

        public decimal AccountBalance { get; set; }
    }
}
