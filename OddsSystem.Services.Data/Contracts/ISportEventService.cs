using OddsSystem.Data.Model;
using System.Collections.Generic;

namespace OddsSystem.Services.Data.Contracts
{
    public interface ISportEventService
    {
        IEnumerable<SportEvent> All();

        bool IsEmpty();

        void Create(SportEvent sportEvent);

        void Delete(long id);

        void Update(SportEvent model);
    }
}
