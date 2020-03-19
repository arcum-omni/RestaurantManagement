using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            CboAccounts.Items.Clear(); 
            PopulateCboAccounts();
        }

        private void PopulateCboAccounts()
        {
            List<FinancialAccount> allAcc = FinancialAccountDB.GetAllFinancialAccounts();

            CboAccounts.Items.Clear();

            foreach (FinancialAccount a in allAcc)
            {
                CboAccounts.Items.Add(a);
            }
            // lst_ExistingAccounts.DataSource = allAcc;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FinancialAccount temp = new FinancialAccount();
            temp.AccountName = txt_AccName.Text;
            temp.AccountDescription = txt_AccDescription.Text;
            FinancialAccountDB.Add(temp);
            frmFinAccManager_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Navigate to Home Screen, close Financial Accounts Manager. 
            frmHomeScreen myForm = new frmHomeScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            FinancialAccount selectedAccount = (FinancialAccount)CboAccounts.SelectedItem;
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            FinancialAccount selectedAccount = (FinancialAccount)CboAccounts.SelectedItem;
            FinancialAccountDB.Delete(selectedAccount);
            CboAccounts.Update();
            frmFinAccManager_Load(sender, e);
        }
    }
}
