using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MetaShare.Common.Core.Daos;
using MetaShare.Common.Core.Daos.MySql;
using MyTest311.Daos;
using MyTest311.Services;
/*add customized code between this region*/
/*add customized code between this region*/

namespace MyTest311.Web
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;

            string connectionString = this.Configuration.GetConnectionString("MyTest311");
            DaoFactory.Instance.ConnectionStringBuilder = new ConnectionStringBuilder(connectionString, typeof(MySqlContext)){SqlDialectType = typeof(MySqlDialect), SqlDialectVersionType = typeof(MySqlDialectVersion)};

            RegisterDaos.RegisterAll(DaoFactory.Instance.ConnectionStringBuilder.SqlDialectType, DaoFactory.Instance.ConnectionStringBuilder.SqlDialectVersionType);
            RegisterServices.RegisterAll();           
            /*add customized code between this region*/
            /*add customized code between this region*/
            //this.RegisterView();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ClassAItem}/{action=Index}/{id?}");

            });
        }
        /*add customized code between this region*/
        /*add customized code between this region*/
    }
}
