using OddsSystem.Data.Model;
using System.Collections.Generic;

namespace OddsSystem.Services.Data.Contracts
{
    public interface ISportEventService
    {
        IEnumerable<SportEvent> All();

        bool IsEmpty();

        SportEvent GetById(long id);

        void Create(SportEvent sportEvent);

        void Delete(long id);

        void Update(SportEvent model);
    }
}
