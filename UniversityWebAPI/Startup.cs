using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.DAL.IRepository;
using University.DAL.Repository;
using University.Logic.Services;
using University.Logic.Services.University.Services;

namespace UniversityWebAPI
{
    public class Startup
    {
       
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddDbContext<UniversityContext>();
                services.AddTransient<IStudentServices, StudentServices>();
                services.AddTransient<IStudentRepository, StudentRepository>();
                services.AddTransient<ILectionRepository, LectionRepository>();
                services.AddTransient<ILectionServices, LectionServices>();
                services.AddTransient<ILectorServices, LectorServices>();
                services.AddTransient<ILectorRepository, LectorRepository>();
                services.AddTransient<ILectionLectorsServices, LectionLectorsServices>();
                services.AddTransient<ILectionLectorsRepository, LectionLectorsRepository>();
                services.AddTransient<IAttendanceServices, AttendanceServices>();
                services.AddTransient<IAttendanceRepository, AttendanceRepository>();
                services.AddControllers(); 
            }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseRouting();



            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
                });
        }


    }
}
