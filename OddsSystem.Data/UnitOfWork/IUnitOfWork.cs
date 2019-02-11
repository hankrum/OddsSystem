using OddsSystem.Data.Model;
using OddsSystem.Data.Repository;
using System.Threading.Tasks;

namespace OddsSystem.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEfRepository<SportEvent> SportEvents { get; }

        Task<int> SaveChanges();
    }
}
