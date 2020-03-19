﻿namespace RestaurantManagement
{
    partial class frmHomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnPointOfSale = new System.Windows.Forms.Button();
            this.btnInventoryControl = new System.Windows.Forms.Button();
            this.btnFinAccounts = new System.Windows.Forms.Button();
            this.btnUserProfiles = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Management Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(138, 79);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 112);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(87, 146);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 32);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnPointOfSale
            // 
            this.btnPointOfSale.Location = new System.Drawing.Point(73, 211);
            this.btnPointOfSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPointOfSale.Name = "btnPointOfSale";
            this.btnPointOfSale.Size = new System.Drawing.Size(239, 32);
            this.btnPointOfSale.TabIndex = 7;
            this.btnPointOfSale.Text = "Point of Sale";
            this.btnPointOfSale.UseVisualStyleBackColor = true;
            this.btnPointOfSale.Click += new System.EventHandler(this.btnPointOfSale_Click);
            // 
            // btnInventoryControl
            // 
            this.btnInventoryControl.Location = new System.Drawing.Point(73, 260);
            this.btnInventoryControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryControl.Name = "btnInventoryControl";
            this.btnInventoryControl.Size = new System.Drawing.Size(239, 32);
            this.btnInventoryControl.TabIndex = 8;
            this.btnInventoryControl.Text = "Inventory Control";
            this.btnInventoryControl.UseVisualStyleBackColor = true;
            this.btnInventoryControl.Click += new System.EventHandler(this.btnInventoryControl_Click);
            // 
            // btnFinAccounts
            // 
            this.btnFinAccounts.Location = new System.Drawing.Point(73, 309);
            this.btnFinAccounts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinAccounts.Name = "btnFinAccounts";
            this.btnFinAccounts.Size = new System.Drawing.Size(239, 32);
            this.btnFinAccounts.TabIndex = 9;
            this.btnFinAccounts.Text = "Financial Accounts";
            this.btnFinAccounts.UseVisualStyleBackColor = true;
            this.btnFinAccounts.Click += new System.EventHandler(this.btnFinAccounts_Click);
            // 
            // btnUserProfiles
            // 
            this.btnUserProfiles.Location = new System.Drawing.Point(73, 357);
            this.btnUserProfiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserProfiles.Name = "btnUserProfiles";
            this.btnUserProfiles.Size = new System.Drawing.Size(239, 32);
            this.btnUserProfiles.TabIndex = 10;
            this.btnUserProfiles.Text = "User Profiles";
            this.btnUserProfiles.UseVisualStyleBackColor = true;
            this.btnUserProfiles.Click += new System.EventHandler(this.btnUserProfiles_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignOut.Location = new System.Drawing.Point(199, 146);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(100, 32);
            this.btnSignOut.TabIndex = 6;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmHomeScreen
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSignOut;
            this.ClientSize = new System.Drawing.Size(385, 451);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnUserProfiles);
            this.Controls.Add(this.btnFinAccounts);
            this.Controls.Add(this.btnInventoryControl);
            this.Controls.Add(this.btnPointOfSale);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnPointOfSale;
        private System.Windows.Forms.Button btnInventoryControl;
        private System.Windows.Forms.Button btnFinAccounts;
        private System.Windows.Forms.Button btnUserProfiles;
        private System.Windows.Forms.Button btnSignOut;
    }
}

