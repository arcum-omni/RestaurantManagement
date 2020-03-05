﻿using System;
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
                    (from i in context.FoodItems
                     select i).ToList();
                foreach (FoodItem item in foodItems)
                {
                    item.ItemIngredients = GetItemIngredients(item.ItemId);
                }

                return foodItems;
            }
        }

        public static List<RawMaterial> GetItemIngredients(int itemId)
        {
            using (var context = new RestaurantContext())
            {
                List<RawMaterial> ingredients =
                    (from r in context.RawMaterials
                     join im in context.ItemMatl
                     on r.RawMatlId equals im.RawMatlId
                     join i in context.FoodItems
                     on im.ItemId equals im.ItemId
                     where i.ItemId == itemId
                     select r).ToList();

                return ingredients;
            }
        }

        public static List<ItemMatl> GetItemMatl(int itemId)
        {
            using (var context = new RestaurantContext())
            {
                List<ItemMatl> itemMatls =
                    (from im in context.ItemMatl
                     join i in context.FoodItems
                     on im.ItemId equals i.ItemId
                     where i.ItemId == itemId
                     select im).ToList();

                return itemMatls;
            }
        }

        public static FoodItem Add(FoodItem item)
        {
            using (var context = new RestaurantContext())
            {
                context.FoodItems.Add(item);
                foreach (RawMaterial material in item.ItemIngredients)
                {
                    context.ItemMatl.Add();
                }
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