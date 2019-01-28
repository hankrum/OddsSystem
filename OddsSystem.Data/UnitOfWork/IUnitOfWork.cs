using OddsSystem.Data.Model;
using OddsSystem.Data.Repository;

namespace OddsSystem.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEfRepository<SportEvent> SportEvents { get; }

        int SaveChanges();
    }
}
