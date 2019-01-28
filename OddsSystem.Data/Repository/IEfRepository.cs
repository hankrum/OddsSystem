using System.Linq;

namespace OddsSystem.Data.Repository
{
    public interface IEfRepository<T> where T : class
    {
        IQueryable<T> All { get; }

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T GetById(long id);
    }
}
