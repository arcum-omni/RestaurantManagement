namespace RestaurantManagement
{
    partial class frmPointOfSale
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
            this.lbxSaleItem = new System.Windows.Forms.ListBox();
            this.lblSaleItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxSaleItem
            // 
            this.lbxSaleItem.FormattingEnabled = true;
            this.lbxSaleItem.Location = new System.Drawing.Point(96, 105);
            this.lbxSaleItem.Name = "lbxSaleItem";
            this.lbxSaleItem.Size = new System.Drawing.Size(120, 147);
            this.lbxSaleItem.TabIndex = 0;
            // 
            // lblSaleItem
            // 
            this.lblSaleItem.AutoSize = true;
            this.lblSaleItem.Location = new System.Drawing.Point(106, 36);
            this.lblSaleItem.Name = "lblSaleItem";
            this.lblSaleItem.Size = new System.Drawing.Size(92, 13);
            this.lblSaleItem.TabIndex = 1;
            this.lblSaleItem.Text = "Select Item to Sell";
            // 
            // frmPointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 418);
            this.Controls.Add(this.lblSaleItem);
            this.Controls.Add(this.lbxSaleItem);
            this.Name = "frmPointOfSale";
            this.Text = "frmPointOfSale";
            this.Load += new System.EventHandler(this.frmPointOfSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSaleItem;
        private System.Windows.Forms.Label lblSaleItem;
    }
}