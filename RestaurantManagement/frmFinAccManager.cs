using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmFinAccManager : Form
    {
        public frmFinAccManager()
        {
            InitializeComponent();
        }

        private void frmFinAccManager_Load(object sender, EventArgs e)
        {
            var tempList = FinancialAccountDB.GetAllFinancialAccounts().ToList();
            lst_ExistingAccounts.DataSource = tempList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FinancialAccount temp = new FinancialAccount();
            temp.AccountName = txt_AccName.Text;
            temp.AccountDescription = txt_AccDescription.Text;
            FinancialAccountDB.Add(temp);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Navigate to Home Screen, close Financial Accounts Manager. 
            frmHomeScreen myForm = new frmHomeScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void lst_ExistingAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
