using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OddsSystem.Data;
using OddsSystem.Data.Repository;
using OddsSystem.Data.UnitOfWork;
using OddsSystem.Extentions;
using OddsSystem.Services.Data;
using OddsSystem.Services.Data.Contracts;

namespace OddsSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            this.Configuration = configuration;
            this.Environment = env;
        }

        public IConfiguration Configuration { get; }

        public IHostingEnvironment Environment { get; }


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
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), 
                b => b.MigrationsAssembly("OddsSystem")));

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
            app.UseDatabaseMigration();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
