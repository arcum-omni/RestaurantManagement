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
                lbxSaleItem.Items.Add(item);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            // TODO: lower item quantity

            // Get item ingradients and lower their quantity
            FoodItem currItem = (FoodItem)lbxSaleItem.SelectedItem;
            ICollection<RawMaterial> itemIngredients = FoodItemDB.GetItemIngredients(currItem.ItemId);

            foreach (RawMaterial item in itemIngredients)
            {
                // TODO: Lower quantity
            }
        }
    }
}
