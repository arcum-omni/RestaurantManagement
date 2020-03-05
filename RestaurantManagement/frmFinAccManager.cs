﻿using System;
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

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // create account
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Navigate to Home Screen, close Financial Accounts Manager. 
            frmHomeScreen myForm = new frmHomeScreen();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
