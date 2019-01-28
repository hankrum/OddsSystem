using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OddsSystem.Data.Model;
using OddsSystem.Services.Data.Contracts;

namespace OddsSystem.Controllers
{
    [Route("api/[controller]")]
    public class SportEventController : Controller
    {
        private ISportEventService sportEventService;

        public SportEventController(ISportEventService sportEventService)
        {
            this.sportEventService = sportEventService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<SportEvent> events = this.sportEventService.All();
            return Json(events);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
