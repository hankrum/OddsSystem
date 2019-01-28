using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OddsSystem.Data;
using OddsSystem.Data.Repository;
using OddsSystem.Data.UnitOfWork;
using OddsSystem.Services.Data;
using OddsSystem.Services.Data.Contracts;

namespace OddsSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            this.RegisterData(services);
            this.RegistrServices(services);
            services.AddMvc();
        }

        private void RegisterData(IServiceCollection services)
        {
            services.AddDbContext<MsSqlDbContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });

            services.BuildServiceProvider().GetService<MsSqlDbContext>().Database.Migrate();

            services.AddScoped(typeof(IEfRepository<>), typeof(EFRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        private void RegistrServices(IServiceCollection services)
        {
            services.AddTransient<ISportEventService, SportEventService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
