using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class RawMaterialDB
    {
        /// <summary>
        /// Returns a list of all raw materials, 
        /// sorted by RawMatlId, in ascending order.
        /// </summary>
        /// <returns></returns>
        public static List<RawMaterial> GetAllRawMaterials()
        {
            using (var context = new RestaurantContext())
            {
                List<RawMaterial> rawMaterials = (from rm in context.RawMaterials
                                                  orderby rm.RawMatlId ascending
                                                  select rm).ToList();
                return rawMaterials;
            }
        }

        /// <summary>
        /// Adds a raw material to the DB
        /// </summary>
        /// <param name="matl"></param>
        /// <returns></returns>
        public static RawMaterial Add(RawMaterial matl)
        {
            using (var context = new RestaurantContext())
            {
                context.RawMaterials.Add(matl);
                context.SaveChanges();
            }
            return matl;
        }

        /// <summary>
        /// Updates/Edits all raw materials data, except for PK
        /// </summary>
        /// <param name="matl"></param>
        /// <returns></returns>
        public static RawMaterial Update(RawMaterial matl)
        {
            using (var context = new RestaurantContext())
            {
                context.RawMaterials.Attach(matl);
                context.Entry(matl).State = EntityState.Modified;
                context.SaveChanges();
            }
            return matl;
        }

        /// <summary>
        /// Deletes a raw material from the DB
        /// </summary>
        /// <param name="matl"></param>
        public static void Delete(RawMaterial matl)
        {
            using (var context = new RestaurantContext())
            {
                context.RawMaterials.Attach(matl);
                context.Entry(matl).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}