using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class BankAccountDB
    {
        public static List<BankAccount> GetBankAccounts()
        {
            using (var context = new RestaurantContext())
            {
                List<BankAccount> bankAccounts = from 
            }
        }

        public static List<BankAccount> Add(BankAccount account)
        {
            using (var context = new RestaurantContext())
            {
                context.BankAccounts.Add(account);
                context.SaveChanges();

                return account;
            }
        }
    }
}
