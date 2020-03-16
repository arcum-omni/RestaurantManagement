using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public class ItemMatl
    {
        [ForeignKey("FoodItem")]
        public int ItemId { get; set; }
        public FoodItem FoodItem { get; set; }

        [ForeignKey("RawMaterial")]
        public int RawMatlId { get; set; }
        public RawMaterial RawMaterial { get; set; }
    }
}
