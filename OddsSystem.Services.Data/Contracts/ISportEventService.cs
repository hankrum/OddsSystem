using OddsSystem.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OddsSystem.Services.Data.Contracts
{
    public interface ISportEventService
    {
        Task<IEnumerable<SportEvent>> All();

        bool IsEmpty();

        Task<SportEvent> GetById(long id);

        Task<SportEvent> Create(SportEvent sportEvent);

        Task<SportEvent> Delete(long id);

        Task<SportEvent> Update(SportEvent model);
    }
}
