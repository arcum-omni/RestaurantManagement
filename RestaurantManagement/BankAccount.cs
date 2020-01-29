using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    /// <summary>
    /// Bank Accounts are financial accounts used to track money (sales & costs) for the restaurant.
    /// Examples of accounts include DailySales, CoGS(Cost of Goods Sold), & the GeneralLedger.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Bank Account Identification Number, Primary Key
        /// </summary>
        [Key]
        public int AccountId { get; set; }

        /// <summary>
        /// The name of the financial account, ie CoGS
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// The account description, 
        /// ie the Cost of Goods Sold, what it costs the restaurant to sell a food item
        /// </summary>
        public string AccountDescription { get; set; }

        /// <summary>
        /// The account balance, ie how much money is in the account.
        /// If the GeneralLedger + DailySales - CoGS < 0 the restaurant is bankrupt.
        /// </summary>
        public decimal AccountBalance { get; set; }
    }
}
