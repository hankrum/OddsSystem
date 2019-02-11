using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OddsSystem.Data.Model;
using OddsSystem.Services.Data.Contracts;

namespace OddsSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportEventController : Controller
    {
        private ISportEventService sportEventService;

        public SportEventController(ISportEventService sportEventService)
        {
            this.sportEventService = sportEventService ?? throw new ArgumentNullException(nameof(sportEventService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SportEvent>>> Get()
        {
            return Json(await this.sportEventService.All());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SportEvent>> Get(long id)
        {
            var sportEvent = await this.sportEventService.GetById(id);

            if (sportEvent == null)
            {
                return NotFound();
            }

            return sportEvent;
        }

        [HttpPost]
        public async Task<SportEvent> Post([FromBody]SportEvent sportEvent)
        {
            var result = await this.sportEventService.Create(sportEvent);

            return result;
        }

        [HttpPut("{id}")]
        public async Task<SportEvent> Put(int id, [FromBody]SportEvent sportEvent)
        {
            return await this.sportEventService.Update(sportEvent);
        }

        [HttpDelete("{id}")]
        public async Task<SportEvent> Delete(int id)
        {
            return await this.sportEventService.Delete(id);
        }
    }
}
