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
    public partial class frmPointOfSale : Form
    {
        public frmPointOfSale()
        {
            InitializeComponent();
        }

        private void frmPointOfSale_Load(object sender, EventArgs e)
        {
            ICollection<FoodItem> foodItems = FoodItemDB.GetAllFoodItems();

            foreach (FoodItem item in foodItems)
            {
                lbxSaleItem.Items.Add(item.ItemName);
            }
        }
    }
}
