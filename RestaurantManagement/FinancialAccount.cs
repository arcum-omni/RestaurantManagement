using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    /// <summary>
    /// Financial accounts used to track funds (credits & debits) for the restaurant.
    /// Examples of accounts include DailySales, CoGS(Cost of Goods Sold), & the Accounts Payable.
    /// </summary>
    public class FinancialAccount
    {
        /// <summary>
        /// No Arg Constructor
        /// </summary>
        public FinancialAccount()
        {
        }

        public FinancialAccount(int AccID, string AccName, string AccDesc, decimal AccBal)
        {
            AccountId = AccID;
            AccountName = AccName;
            AccountDescription = AccDesc;
            AccountBalance = AccBal;
        }

        /// <summary>
        /// Financial Account Identification Number, Primary Key
        /// </summary>
        [Key]
        public int AccountId { get; set; }

        /// <summary>
        /// The name of the financial account: IE Accounts Payable (AP)
        /// </summary>
        [Required]
        public string AccountName { get; set; }

        /// <summary>
        /// The account description, 
        /// IE AP is money owed by a business to its suppliers shown as a liability on a company's balance sheet.
        /// </summary>
        public string AccountDescription { get; set; }

        /// <summary>
        /// The account balance, IE how much money is in the account for a specific purpose.
        /// </summary>
        public decimal AccountBalance { get; private set; }

        /// <summary>
        /// Override inherited ToString() to provide specific information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            CultureInfo ci = new CultureInfo("en-us");
            return $"Account Name: {AccountName}  Acc#: {AccountId}";
        }
    }
}
