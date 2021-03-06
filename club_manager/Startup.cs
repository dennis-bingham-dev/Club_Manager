using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using club_manager.BusinessLogic.EnumTest;
using club_manager.Controller;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace club_manager
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<TestEnumBLL>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors("AllowAll");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                // endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
                /* endpoints.MapControllerRoute(
                    name: "Member",
                    pattern: "{controller=Member}/{action=GetAllMembers}"
                );
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Member}/{action=GetMemberById}/{id?}"
                    ); */
            });
        }
    }
}