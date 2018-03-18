using FurnitureFun.Data;
using FurnitureFun.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
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
            {      // Eagerly loading the Department values too so they will be available after the connection closes. 
                return context.Furnitures.Include(f=>f.Department).OrderBy(f => f.Name).ToList();
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
                return context.Furnitures.Where(f => f.Id == furnitureId).Include(f=>f.Department).SingleOrDefault();

            }
        }



    }
}                  



    