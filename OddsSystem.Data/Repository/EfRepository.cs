using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using Infrastructure;
using System.Threading.Tasks;

namespace OddsSystem.Data.Repository
{
    public class EFRepository<T> : IEfRepository<T> where T : class
    {
        private readonly MsSqlDbContext context;


        public EFRepository(MsSqlDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<T> All
        {
            get
            {
                return this.context.Set<T>().AsQueryable();
            }
        }

        public T Add(T entity)
        {
            Validated.NotNull(entity, nameof(entity));
            EntityEntry entry = this.context.Entry(entity);

            return this.context.Set<T>().Add(entity).Entity;
        }

        public T Delete(T entity)
        {
            Validated.NotNull(entity, nameof(entity));
            var entry = this.context.Entry(entity);

            return this.context.Set<T>().Remove(entity).Entity;
        }

        public T Update(T entity)
        {
            Validated.NotNull(entity, nameof(entity));
            EntityEntry entry = this.context.Entry(entity);

            return this.context.Set<T>().Update(entity).Entity;
        }

        public async Task<T> GetById(long id)
        {
            return await this.context.Set<T>().FindAsync(id);
        }
    }
}
