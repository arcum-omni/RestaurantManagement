using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class FoodItems
    {
        [Key]
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public List<RawMaterial> ItemIngredients { get; set; }

        public decimal ItemPrice { get; set; }
    }
}
