using AutoMapper;
using CollegeManagement.Api.Models;
using CollegeManagement.Api.Repositories;
using CollegeManagement.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api
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
			services.AddControllers();

			services.AddAutoMapper(typeof(Startup));
			services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultDatabase")));

			services.AddScoped<IBuildingService, BuildingService>();
			services.AddScoped<IBuildingRepository, BuildingRepository>();
			services.AddScoped<IGroupService, GroupService>();
			services.AddScoped<IGroupRepository, GroupRepository>();
			services.AddScoped<ICollegeService, CollegeService>();
			services.AddScoped<ICollegeRepository, CollegeRepository>();
			services.AddScoped<IEmployeeService, EmployeeService>();
			services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			services.AddScoped<IPayCheckService, PayCheckService>();
			services.AddScoped<IPayCheckRepository, PayCheckRepository>();
			services.AddScoped<IStudentService, StudentService>();
			services.AddScoped<IStudentRepository, StudentRepository>();
			services.AddScoped<IStudentTeacherService, StudentTeacherService>();
			services.AddScoped<IStudentTeacherRepository, StudentTeacherRepository>();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
