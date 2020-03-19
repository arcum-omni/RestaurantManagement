namespace RestaurantManagement
{
    partial class frmFinAccManager
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
            this.txt_AccID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AccName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AccDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AccBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.CboAccounts = new System.Windows.Forms.ComboBox();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account ID:";
            // 
            // txt_AccID
            // 
            this.txt_AccID.Enabled = false;
            this.txt_AccID.Location = new System.Drawing.Point(225, 97);
            this.txt_AccID.Name = "txt_AccID";
            this.txt_AccID.Size = new System.Drawing.Size(197, 26);
            this.txt_AccID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Name:";
            // 
            // txt_AccName
            // 
            this.txt_AccName.Location = new System.Drawing.Point(225, 147);
            this.txt_AccName.Name = "txt_AccName";
            this.txt_AccName.Size = new System.Drawing.Size(197, 26);
            this.txt_AccName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Description:";
            // 
            // txt_AccDescription
            // 
            this.txt_AccDescription.Location = new System.Drawing.Point(225, 197);
            this.txt_AccDescription.Name = "txt_AccDescription";
            this.txt_AccDescription.Size = new System.Drawing.Size(197, 26);
            this.txt_AccDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Account Balance:";
            // 
            // txt_AccBalance
            // 
            this.txt_AccBalance.Location = new System.Drawing.Point(225, 247);
            this.txt_AccBalance.Name = "txt_AccBalance";
            this.txt_AccBalance.Size = new System.Drawing.Size(197, 26);
            this.txt_AccBalance.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Financial Accounts Manager";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(70, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 60);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save / Create";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(252, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 60);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Existing Accounts:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(150, 500);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 60);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Edit Selected Account";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // CboAccounts
            // 
            this.CboAccounts.FormattingEnabled = true;
            this.CboAccounts.Location = new System.Drawing.Point(50, 450);
            this.CboAccounts.Name = "CboAccounts";
            this.CboAccounts.Size = new System.Drawing.Size(368, 28);
            this.CboAccounts.TabIndex = 14;
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Location = new System.Drawing.Point(150, 600);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(150, 60);
            this.btnDeleteAcc.TabIndex = 15;
            this.btnDeleteAcc.Text = "Delete Account";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // frmFinAccManager
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 844);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.CboAccounts);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_AccBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AccDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AccName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AccID);
            this.Controls.Add(this.label1);
            this.Name = "frmFinAccManager";
            this.Text = "Accounts Manager";
            this.Load += new System.EventHandler(this.frmFinAccManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AccID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AccName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AccDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AccBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox CboAccounts;
        private System.Windows.Forms.Button btnDeleteAcc;
    }
}