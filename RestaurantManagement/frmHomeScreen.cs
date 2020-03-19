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
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        private void btnInventoryControl_Click(object sender, EventArgs e)
        {
            // open inventory control form
        }

        private void btnFinAccounts_Click(object sender, EventArgs e)
        {
            // Navigate to Financial Accounts Manager, close Home Screen form.
            frmFinAccManager myForm = new frmFinAccManager();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnUserProfiles_Click(object sender, EventArgs e)
        {
            // open user profiles form
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // user sign in
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // user sign out
        }

        private void btnPointOfSale_Click(object sender, EventArgs e)
        {
            frmPointOfSale pointOfSale = new frmPointOfSale();
            pointOfSale.ShowDialog();
        }
    }
}
