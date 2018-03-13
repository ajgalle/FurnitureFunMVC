using FurnitureFunDAL.Data;
using FurnitureFunDAL.Models;
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
    }
}
//        /// <summary>
//        /// Returns a list of series ordered by title.
//        /// </summary>
//        /// <returns>An IList collection of Series entity instances.</returns>
//        public static IList<Series> GetSeries()
//        {
//            using (Context context = GetContext())
//            {
//                return context.Series
//                    .OrderBy(s => s.Title)
//                    .ToList();
//            }
//        }

//        /// <summary>
//        /// Returns a single series.
//        /// </summary>
//        /// <param name="seriesId">The series ID to retrieve.</param>
//        /// <returns>A Series entity instance.</returns>
//        public static Series GetSeries(int seriesId)
//        {
//            using (Context context = GetContext())
//            {
//                return context.Series
//                    .Where(s => s.Id == seriesId)
//                    .SingleOrDefault();
//            }
//        }

//        /// <summary>
//        /// Returns a list of artists ordered by name.
//        /// </summary>
//        /// <returns>An IList collection of Artist entity instances.</returns>
//        public static IList<Artist> GetArtists()
//        {
//            using (Context context = GetContext())
//            {
//                return context.Artists
//                    .OrderBy(a => a.Name)
//                    .ToList();
//            }
//        }

//        /// <summary>
//        /// Returns a list of roles ordered by name.
//        /// </summary>
//        /// <returns>An IList collection of Role entity instances.</returns>
//        public static IList<Role> GetRoles()
//        {
//            using (Context context = GetContext())
//            {
//                return context.Roles
//                    .OrderBy(r => r.Name)
//                    .ToList();
//            }
//        }

//        /// <summary>
//        /// Adds a comic book.
//        /// </summary>
//        /// <param name="comicBook">The ComicBook entity instance to add.</param>
//        public static void AddComicBook(ComicBook comicBook)
//        {
//            using (Context context = GetContext())
//            {
//                context.ComicBooks.Add(comicBook);

//                if (comicBook.Series != null && comicBook.Series.Id > 0)
//                {
//                    context.Entry(comicBook.Series).State = EntityState.Unchanged;
//                }

//                foreach (ComicBookArtist artist in comicBook.Artists)
//                {
//                    if (artist.Artist != null && artist.Artist.Id > 0)
//                    {
//                        context.Entry(artist.Artist).State = EntityState.Unchanged;
//                    }

//                    if (artist.Role != null && artist.Role.Id > 0)
//                    {
//                        context.Entry(artist.Role).State = EntityState.Unchanged;
//                    }
//                }

//                context.SaveChanges();
//            }
//        }

//        /// <summary>
//        /// Updates a comic book.
//        /// </summary>
//        /// <param name="comicBook">The ComicBook entity instance to update.</param>
//        public static void UpdateComicBook(ComicBook comicBook)
//        {
//            using (Context context = GetContext())
//            {
//                context.ComicBooks.Attach(comicBook);
//                var comicBookEntry = context.Entry(comicBook);
//                comicBookEntry.State = EntityState.Modified;
//                //comicBookEntry.Property("IssueNumber").IsModified = false;

//                context.SaveChanges();
//            }
//        }

//        /// <summary>
//        /// Deletes a comic book.
//        /// </summary>
//        /// <param name="comicBookId">The comic book ID to delete.</param>
//        public static void DeleteComicBook(int comicBookId)
//        {
//            using (Context context = GetContext())
//            {
//                var comicBook = new ComicBook() { Id = comicBookId };
//                context.Entry(comicBook).State = EntityState.Deleted;

//                context.SaveChanges();
//            }
//        }
//    }
//}




    