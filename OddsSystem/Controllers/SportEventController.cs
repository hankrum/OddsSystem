using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OddsSystem.Data.Model;
using OddsSystem.Services.Data.Contracts;

namespace OddsSystem.Controllers
{
    [Route("api/sportevent")]
    public class SportEventController : Controller
    {
        private ISportEventService sportEventService;

        public SportEventController(ISportEventService sportEventService)
        {
            this.sportEventService = sportEventService ?? throw new ArgumentNullException(nameof(sportEventService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<SportEvent> events = this.sportEventService.All();
            return Json(events);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            SportEvent sportEvent = this.sportEventService.GetById(id);
            return Json(sportEvent);
        }

        [HttpPost]
        public void Post([FromBody]SportEvent sportEvent)
        {
            this.sportEventService.Create(sportEvent);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]SportEvent sportEvent)
        {
            this.sportEventService.Update(sportEvent);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.sportEventService.Delete(id);
        }
    }
}
