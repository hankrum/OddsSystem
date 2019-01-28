using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;

namespace OddsSystem.Data.Repository
{
    public class EFRepository<T> : IEfRepository<T> where T : class
    {
        private readonly MsSqlDbContext context;


        public EFRepository(MsSqlDbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> All
        {
            get
            {
                return this.context.Set<T>();
            }
        }

        public void Add(T entity)
        {
            EntityEntry entry = this.context.Entry(entity);

            this.context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            var entry = this.context.Entry(entity);
            this.context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            EntityEntry entry = this.context.Entry(entity);
                this.context.Set<T>().Update(entity);
        }

        public T GetById(long id)
        {
            return this.context.Set<T>().Find(id);
        }
    }
}
