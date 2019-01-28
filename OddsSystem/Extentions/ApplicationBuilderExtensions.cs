using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OddsSystem.Data;
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


                //Task.Run(async () =>
                //{
                //    var adminUserName = WebConstants.AdminRole;

                //    var roles = new[]
                //    {
                //            adminUserName,
                //            WebConstants.MasterAdminRole
                //        };

                //    foreach (var role in roles)
                //    {
                //        var roleExists = await roleManager.RoleExistsAsync(role);

                //        if (!roleExists)
                //        {
                //            await roleManager.CreateAsync(new IdentityRole
                //            {
                //                Name = role
                //            });
                //        }
                //    }

                //    var adminEmail = "admin@adminsite.com";

                //    var adminUser = await userManager.FindByEmailAsync(adminEmail);

                //    if (adminUser == null)
                //    {
                //        adminUser = new User
                //        {
                //            Email = adminEmail,
                //            UserName = adminUserName
                //        };

                //        await userManager.CreateAsync(adminUser, "Admin123_");

                //        await userManager.AddToRoleAsync(adminUser, adminUserName);
                //        await userManager.AddToRoleAsync(adminUser, WebConstants.MasterAdminRole);
                //    }
                //})
                //    .Wait();
            }

            return app;
        }
    }
}
