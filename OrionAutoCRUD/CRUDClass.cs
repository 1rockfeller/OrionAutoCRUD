using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionAutoCRUD
{
    public static class CRUDClass<TEntity> where TEntity : class
    {
        public static DbContext context { get; set; }
        public static string connectionString { get; set; }

        /// <summary>
        /// Initialize the DbContext with the connectionString
        /// </summary>
        /// <param name="connectionString">The database connection string</param>
        public static void Initialize(string connectionString)
        {
            context = new DbContext(connectionString);
        }

        /// <summary>
        /// Initialize the DbContext with the connectionString
        /// </summary>
        /// <param name="ctx">The database context </param>
        public static void Initialize(DbContext ctx)
        {
            context = ctx;
        }

        /// <summary>
        /// Insert the object to the DbSet
        /// </summary>
        /// <param name="entity">The object to insert</param>
        public static void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Update the object
        /// </summary>
        /// <param name="id">Id of the object to update</param>
        /// <param name="entity">Object with new data</param>
        public static void Update(int id,TEntity entity)
        {
            var item = context.Set<TEntity>().Find(id);
            if(item != null)
            {
                context.Entry<TEntity>(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deelete an object from the DbSet
        /// </summary>
        /// <param name="id">Id (int) of the object to delete</param>
        public static void Delete(int id)
        {
            var item = context.Set<TEntity>().Find(id);
            if (item != null)
            {
                context.Set<TEntity>().Remove(item);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deelete an object from the DbSet
        /// </summary>
        /// <param name="id">Id 'string) of the object to delete</param>
        public static void Delete(string id)
        {
            var item = context.Set<TEntity>().Find(id);
            if (item != null)
            {
                context.Set<TEntity>().Remove(item);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get all entries from the Database
        /// </summary>
        /// <returns></returns>
        public static List<TEntity> Get()
        {
            return context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Get a specific element from the Database
        /// </summary>
        /// <param name="id">Id of the element to get</param>
        /// <returns></returns>
        public static TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Get a specific element from the DbSet
        /// </summary>
        /// <param name="id">Id of the element to get</param>
        /// <returns>Returns TEntity</returns>
        public static TEntity Get(string id)
        {
            return context.Set<TEntity>().Find(id);
        }
    }
}
