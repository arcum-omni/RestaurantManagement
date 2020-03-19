using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public static class FinancialAccountDB
    {
        /// <summary>
        /// Returns a list of all financial accounts,
        /// sorted by AccountId, in ascending order.
        /// </summary>
        /// <returns></returns>
        public static List<FinancialAccount> GetAllFinancialAccounts()
        {
            using (var context = new RestaurantContext())
            {
                List<FinancialAccount> acc = (from fa in context.FinancialAccounts 
                                              orderby fa.AccountId ascending
                                              select fa).ToList();

                return acc;
            }
        }

        /// <summary>
        /// Adds a financial account to the DB
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public static FinancialAccount Add(FinancialAccount acc)
        {
            using (var context = new RestaurantContext())
            {
                context.FinancialAccounts.Add(acc);
                context.SaveChanges();
            }
            return acc;
        }

        /// <summary>
        /// Updates/Edits all financial account data, except for PK
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public static FinancialAccount Update(FinancialAccount acc)
        {
            using (var context = new RestaurantContext())
            {
                context.FinancialAccounts.Attach(acc);
                context.Entry(acc).State = EntityState.Modified;
                context.SaveChanges();
            }
            return acc;
        }

        /// <summary>
        /// Deletes a financial account from the DB
        /// </summary>
        /// <param name="acc"></param>
        public static void Delete(FinancialAccount acc)
        {
            using (var context = new RestaurantContext())
            {
                // TODO:  Complete Delete functionality
                context.FinancialAccounts.Attach(acc);
                context.Entry(acc).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}