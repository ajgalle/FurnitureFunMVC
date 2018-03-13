using FurnitureFunDAL.Data;
using FurnitureFunDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FurnitureFun.Data
{
    /// <summary>
    /// Repository class that provides various database queries
    /// and CRUD operations.
    /// </summary>
    public static class FurnitureRepository
    {
        /// <summary>
        /// Private method that returns a database context.
        /// </summary>
        /// <returns>An instance of the Context class.</returns>
        static Context GetContext()
        {
            var context = new Context();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }

        /// <summary>
        /// Returns a count of the entire furnitures.
        /// </summary>
        /// <returns>An integer count of the furniture.</returns>
        public static int GetFurnitureCount()
        {
            using (Context context = GetContext())
            {
                return context.Furnitures.Count();
            }
        }

        /// <summary>
        /// Returns a list of furniture ordered by the name 
        /// 
        /// </summary>
        /// <returns>An IList collection of Furniture entity instances.</returns>

        public static IList<Furniture> GetAllFurniture()
        {
            using (Context context = GetContext())
            {
                return context.Furnitures.OrderBy(f => f.Name).ToList();
            }
        }

        /// <summary>
        /// Returns a single furniture.
        /// </summary>
        /// <param name="furnitureId"> The furniture ID to retrieve.</param>
        /// <returns>A fully populated furniture entity instance.</returns>
        public static Furniture GetFurniture(int furnitureId)
        {
            using (Context context = GetContext())
            {
                return context.Furnitures.Where(f => f.Id == furnitureId).SingleOrDefault();

            }
        }                               

        /// <summary>
        /// Adds a furniture piece.
        /// </summary>
        /// <param name="furniture">The furniture entity instance to add.</param>
        public static void AddFurniture(Furniture furniture)
        {
            using (Context context = GetContext())
            {
                context.Furnitures.Add(furniture);
                             

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates a furniture book.
        /// </summary>
       /// <param name="furniture">The furniture entity instance to update.</param>
        public static void UpdateFurniture(Furniture furniture)
        {
           using (Context context = GetContext())
            {
                context.Furnitures.Attach(furniture);
                var furnitureEntry = context.Entry(furniture);
                furnitureEntry.State = EntityState.Modified;
                
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes furniture.
        /// </summary>
        /// <param name="furnitureId">The furniture ID to delete.</param>
        public static void DeleteFurniture(int furnitureId)
        {
            using (Context context = GetContext())
            {
                var furniture = new Furniture() { Id = furnitureId };
                context.Entry(furniture).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}




