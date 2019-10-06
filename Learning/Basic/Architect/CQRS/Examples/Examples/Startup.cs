using System.Reflection;
using Examples.Commands;
using Examples.Models;
using Examples.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;


namespace Examples
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
            //starting of the interface programming.
            services.AddScoped<ICommandService, CommandService>(ctor => new CommandService(Configuration["ConnectionString"]));
            services.AddScoped<IQueryService, QueryService>(ctor => new QueryService(Configuration["ConnectionString"]));

            //services.AddDbContext<MvcMovieContext>(options =>
            //      options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            services.AddDbContext<ProductContext>(optionsAction: optionsBuilder =>
             optionsBuilder.UseSqlServer(Configuration["ConnectionString"],
             optionsAction => optionsAction.MigrationsAssembly(typeof(ProductContext).GetTypeInfo().Assembly.GetName().Name)));

           // services.addd
            // End of the interface programming

            services.AddControllersWithViews();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
