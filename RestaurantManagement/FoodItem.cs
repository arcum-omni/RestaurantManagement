using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    /// <summary>
    /// FoodItems are food &/or beverage items ready for retail sale. 
    /// </summary>
    public class FoodItem
    {
        /// <summary>
        /// Food Item Identification Number, Primary Key
        /// </summary>
        [Key]
        public int ItemId { get; set; }

        /// <summary>
        /// The name of the food item, ie Cinnamon Roll
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// The description of the food item,
        /// ie Our cinnamon rolls consist of a rolled sheet of yeast-leavened dough onto which a cinnamon and sugar mixture is sprinkled over a thin coat of butter. The dough is then rolled, cut into individual portions, and baked or deep fried.
        /// </summary>RawMaterial
        public string ItemDescription { get; set; }

        /// <summary>
        /// The item ingredients is a list of raw materials used to create the food item.
        /// </summary>
        public virtual ICollection<ItemMatl> ItemMatls { get; set; }

        /// <summary>
        /// The retail price charged for a food item.
        /// </summary>
        public decimal ItemPrice { get; set; }
    }
}
