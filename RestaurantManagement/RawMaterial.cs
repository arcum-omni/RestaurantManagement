using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    /// <summary>
    /// Raw materials are used to prepare FoodItems for retail sale.
    /// </summary>
    public class RawMaterial
    {
        /// <summary>
        /// Raw Material Identification Number, Primary Key
        /// </summary>
        [Key]
        public int RawMatlId { get; set; }

        /// <summary>
        /// Name of Raw Material, ie flour
        /// </summary>
        public string RawMatlName { get; set; }

        /// <summary>
        /// Raw Material Description, ie Gold Medal All Purpose Flour
        /// </summary>
        public string RawMatlDescription { get; set; }

        /// <summary>
        /// Raw Material Quantity, this property is used to track the quantity of a raw material in inventory, ie 25,000 grams (25kg)
        /// </summary>
        public int RawMatlQuantity { get; set; }

        /// <summary>
        /// Raw Material Cost, this property is used to calculate Cost of Goods Sold (CoGS).
        /// </summary>
        public double RawMatlCost { get; set; }

        public virtual FoodItem FoodItem { get; set; }
    }
}
