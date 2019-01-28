using OddsSystem.Data.Model;
using OddsSystem.Data.Repository;
using System;

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
                //if (this.sportEvents == null)
                //{
                //    this.sportEvents = new EFRepository<SportEvent>(context);
                //}

                return this.sportEvents;
            }
        }


        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
