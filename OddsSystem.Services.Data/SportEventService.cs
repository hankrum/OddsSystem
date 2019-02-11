using Infrastructure;
using Microsoft.EntityFrameworkCore;
using OddsSystem.Data.Model;
using OddsSystem.Data.UnitOfWork;
using OddsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OddsSystem.Services.Data
{
    public class SportEventService : ISportEventService
    {
        private readonly IUnitOfWork unitOfWork;

        public SportEventService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<IEnumerable<SportEvent>> All()
        {
            IEnumerable<SportEvent> events = await this.unitOfWork.SportEvents.All.ToListAsync();
            return events;
        }

        public async Task<SportEvent> GetById(long id)
        {
            return await this.unitOfWork.SportEvents.GetById(id);
        }

        public bool IsEmpty()
        {
            return !this.unitOfWork.SportEvents.All.Any();
        }

        public async Task<SportEvent> Create(SportEvent sportEvent)
        {
            Validated.NotNull(sportEvent, nameof(sportEvent));

            SportEvent addedSportEvent = this.unitOfWork.SportEvents.Add(sportEvent);

            await this.unitOfWork.SaveChanges();

            return addedSportEvent;
        }

        public async Task<SportEvent> Delete(long id)
        {
            var model = await this.unitOfWork.SportEvents.GetById(id);
            SportEvent deletedSportEvent = this.unitOfWork.SportEvents.Delete(model);

            await this.unitOfWork.SaveChanges();

            return deletedSportEvent;
        }

        public async Task<SportEvent> Update(SportEvent sportEvent)
        {
            Validated.NotNull(sportEvent, nameof(sportEvent));

            SportEvent updatedSportEvent = this.unitOfWork.SportEvents.Update(sportEvent);

            await this.unitOfWork.SaveChanges();

            return updatedSportEvent;
        }
    }
}
