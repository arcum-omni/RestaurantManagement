using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public static class BankAccountDB
    {
        /// <summary>
        /// Returns a list of all bank/financial accounts,
        /// sorted by account number, in ascending order.
        /// </summary>
        /// <returns></returns>
        public static List<BankAccount> GetBankAccounts()
        {
            using (var context = new RestaurantContext())
            {
                List<BankAccount> bankAccounts = (from ba in context.BankAccounts
                                                  orderby ba.AccountId ascending
                                                  select ba).ToList();

                return bankAccounts;
            }
        }

        /// <summary>
        /// Adds a financial account to the DB
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public static BankAccount Add(BankAccount acc)
        {
            using (var context = new RestaurantContext())
            {
                context.BankAccounts.Add(acc);
                context.SaveChanges();
            }
            return acc;
        }

        /// <summary>
        /// Deletes a financial account from the DB
        /// </summary>
        /// <param name="acc"></param>
        public static void Delete(BankAccount acc)
        {
            using (var context = new RestaurantContext())
            {
                context.BankAccounts.Attach(acc);
                context.Entry(acc).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates/Edits all financial account data, except for PK
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public static BankAccount Update(BankAccount acc)
        {
            using (var context = new RestaurantContext())
            {
                context.BankAccounts.Attach(acc);
                context.Entry(acc).State = EntityState.Modified;
                context.SaveChanges();
            }
            return acc;
        }
    }
}