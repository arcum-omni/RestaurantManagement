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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account ID:";
            // 
            // txt_AccID
            // 
            this.txt_AccID.Enabled = false;
            this.txt_AccID.Location = new System.Drawing.Point(150, 63);
            this.txt_AccID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AccID.Name = "txt_AccID";
            this.txt_AccID.Size = new System.Drawing.Size(133, 20);
            this.txt_AccID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Name:";
            // 
            // txt_AccName
            // 
            this.txt_AccName.Location = new System.Drawing.Point(150, 94);
            this.txt_AccName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AccName.Name = "txt_AccName";
            this.txt_AccName.Size = new System.Drawing.Size(133, 20);
            this.txt_AccName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Description:";
            // 
            // txt_AccDescription
            // 
            this.txt_AccDescription.Location = new System.Drawing.Point(150, 128);
            this.txt_AccDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AccDescription.Name = "txt_AccDescription";
            this.txt_AccDescription.Size = new System.Drawing.Size(133, 20);
            this.txt_AccDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Account Balance:";
            // 
            // txt_AccBalance
            // 
            this.txt_AccBalance.Location = new System.Drawing.Point(150, 161);
            this.txt_AccBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AccBalance.Name = "txt_AccBalance";
            this.txt_AccBalance.Size = new System.Drawing.Size(133, 20);
            this.txt_AccBalance.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Financial Accounts Manager";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 195);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 32);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(181, 195);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Create";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmFinAccManager
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(322, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_AccBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AccDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AccName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AccID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}