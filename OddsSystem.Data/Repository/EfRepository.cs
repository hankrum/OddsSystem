using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using Infrastructure;

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

        public void Add(T entity)
        {
            Validated.NotNull(entity, nameof(entity));
            EntityEntry entry = this.context.Entry(entity);

            this.context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Validated.NotNull(entity, nameof(entity));
            var entry = this.context.Entry(entity);
            this.context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            Validated.NotNull(entity, nameof(entity));
            EntityEntry entry = this.context.Entry(entity);
                this.context.Set<T>().Update(entity);
        }

        public T GetById(long id)
        {
            return this.context.Set<T>().Find(id);
        }
    }
}
