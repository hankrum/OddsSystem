using OddsSystem.Data.Model;
using OddsSystem.Data.UnitOfWork;
using OddsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;

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
            IEnumerable<SportEvent> models = new List<SportEvent>
            {
                new SportEvent
                {
                    EventName = "LiverPool-Juventus",
                    OddsForFirstTeam = 1.95,
                    OddsForDraw = 3.15,
                    OddsForSecondTeam = 2.20,
                    EventStartDate = new DateTime(2019,12,25,22,0, 0)
                },
                 new SportEvent
               {
                    EventName = "Grigor Dimitrov-Rafael Nadal",
                    OddsForFirstTeam = 1.95,
                    OddsForDraw = 3.15,
                    OddsForSecondTeam = 2.20,
                    EventStartDate = new DateTime(2019,12,25,22,0, 0)
                },
                new SportEvent
                {
                    EventName = "Barcelona-Ludogorets",
                    OddsForFirstTeam = 1.95,
                    OddsForDraw = 3.15,
                    OddsForSecondTeam = 2.20,
                    EventStartDate = new DateTime(2019,01,25,22,0, 0)
                },
            };
            return models;
        }

        public SportEvent Create()
        {
            throw new NotImplementedException();
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
