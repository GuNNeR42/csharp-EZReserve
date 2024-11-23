using csharp_EZReserve.Models.Factories;
using Microsoft.EntityFrameworkCore;

namespace csharp_EZReserve.Models.Seeders
{
    public abstract class BaseSeeder<T> where T : class
    {
        protected readonly DbContext Context;
        protected readonly BaseFactory<T> Factory;
        protected readonly int DefaultCount;

        protected BaseSeeder(DbContext context, BaseFactory<T> factory, int defaultCount = 50)
        {
            Context = context;
            Factory = factory;
            DefaultCount = defaultCount;
        }

        public abstract Task SeedAsync(int? count = null);

        protected async Task SaveChangesWithIdentityInsertAsync<TEntity>(DbSet<TEntity> dbSet, IEnumerable<TEntity> entities) where TEntity : class
        {
            await dbSet.AddRangeAsync(entities);
            await Context.SaveChangesAsync();
        }
    }
}
