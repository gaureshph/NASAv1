using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using NASAv1.Web.Middleware;
using NASAv1.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace NASAv1.Web
{
    public class Startup
    {

        private IConfiguration Configuration;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(env.ContentRootPath)
                            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<NASADbContext>(options => 
                                        options.UseSqlServer(Configuration.GetConnectionString("NASADbContext"))
                                        );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();

            app.UseBowerComponents(env.ContentRootPath);

            app.UseMvc(routes =>
                        routes.MapRoute("DefaultRoute", "{controller=Rocket}/{action=Index}/{id?}")
            );
        }
    }
}
