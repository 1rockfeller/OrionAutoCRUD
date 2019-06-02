using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionAutoCRUD
{
    public class CRUDClass<TEntity> : ICRUD<TEntity>  where TEntity : class
    {
        public DbContext context { get; set; }
        public void Initialize(string connectionString)
        {
            context = new DbContext(connectionString);
        }

        public Task UpdateAsync(int id, TEntity entity)
        {
            throw new NotImplementedException();
        }

        protected async Task InsertAsync(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
        }

        Task ICRUD<TEntity>.InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
