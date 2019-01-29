using OddsSystem.Data.Model;
using OddsSystem.Data.UnitOfWork;
using OddsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OddsSystem.Services.Data
{
    public class SportEventService : ISportEventService
    {
        private readonly IUnitOfWork unitOfWork;

        public SportEventService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public IEnumerable<SportEvent> All()
        {
            IEnumerable<SportEvent> events = this.unitOfWork.SportEvents.All.ToList();
            return events;
        }

        public bool IsEmpty()
        {
            return !this.unitOfWork.SportEvents.All.Any();
        }

        public void Create(SportEvent sportEvent)
        {
            this.unitOfWork.SportEvents.Add(sportEvent);

            this.unitOfWork.SaveChanges();
        }

        public void Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public void Update(long Id)
        {
            throw new NotImplementedException();
        }
    }
}
