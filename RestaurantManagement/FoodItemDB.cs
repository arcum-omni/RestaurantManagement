using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public static class FoodItemDB
    {
        public static List<FoodItem> GetAllFoodItems()
        {
            using (var context = new RestaurantContext())
            {
                List<FoodItem> foodItems =
                    context.FoodItems
                    .OrderBy(item => item.ItemId)
                    .ToList();

                return foodItems;
            }
        }

        public static FoodItem Add(FoodItem item)
        {
            using (var context = new RestaurantContext())
            {
                context.FoodItems.Add(item);
                context.SaveChanges();

                return item;
            }
        }

        public static void Delete(FoodItem item)
        {
            using (var context = new RestaurantContext())
            {
                context.FoodItems.Attach(item);
                context.Entry(item).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public static FoodItem Update(FoodItem item)
        {
            using (var context = new RestaurantContext())
            {
                context.FoodItems.Attach(item);
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();

                return item;
            }
        }
    }
}
