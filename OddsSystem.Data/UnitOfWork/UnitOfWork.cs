using OddsSystem.Data.Model;
using OddsSystem.Data.Repository;
using System;
using System.Threading.Tasks;

namespace OddsSystem.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MsSqlDbContext context;
        private IEfRepository<SportEvent> sportEvents;

        public UnitOfWork(MsSqlDbContext context, IEfRepository<SportEvent> sportEvents)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.sportEvents = sportEvents ?? throw new ArgumentNullException(nameof(sportEvents));
        }

        public IEfRepository<SportEvent> SportEvents
        {
            get
            {
                return this.sportEvents;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}
