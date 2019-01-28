using OddsSystem.Data.Model;
using System.Collections.Generic;

namespace OddsSystem.Services.Data.Contracts
{
    public interface ISportEventService
    {
        IEnumerable<SportEvent> All();
        SportEvent Create();
        void Delete(long Id);
        void Update(long Id);
    }
}
