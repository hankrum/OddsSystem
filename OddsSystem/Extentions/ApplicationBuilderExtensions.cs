using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OddsSystem.Data;
using OddsSystem.Data.Model;
using OddsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OddsSystem.Extentions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<MsSqlDbContext>().Database.Migrate();

            //    var eventsService = serviceScope.ServiceProvider.GetService<ISportEventService>();

            //    IEnumerable<SportEvent> events = new List<SportEvent>
            //{
            //    new SportEvent
            //    {
            //        EventName = "LiverPool-Juventus",
            //        OddsForFirstTeam = 1.95,
            //        OddsForDraw = 3.15,
            //        OddsForSecondTeam = 2.20,
            //        EventStartDate = new DateTime(2019,12,25,22,0, 0)
            //    },
            //     new SportEvent
            //   {
            //        EventName = "Grigor Dimitrov-Rafael Nadal",
            //        OddsForFirstTeam = 1.95,
            //        OddsForDraw = 3.15,
            //        OddsForSecondTeam = 2.20,
            //        EventStartDate = new DateTime(2019,12,25,22,0, 0)
            //    },
            //    new SportEvent
            //    {
            //        EventName = "Barcelona-Ludogorets",
            //        OddsForFirstTeam = 1.95,
            //        OddsForDraw = 3.15,
            //        OddsForSecondTeam = 2.20,
            //        EventStartDate = new DateTime(2019,01,25,22,0, 0)
            //    },
            //};
            //    if (eventsService.IsEmpty())
            //    {
            //        foreach (var item in events)
            //        {
            //            eventsService.Create(item);
            //        }
            //    }
            }

            return app;
        }
    }
}
