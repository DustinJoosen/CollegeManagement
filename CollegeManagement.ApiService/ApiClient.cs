using CollegeManagement.ApiService.Services;
using System;
using System.Net.Http;

namespace CollegeManagement.ApiService
{
	public class ApiClient : IDisposable
	{
		public HttpClient HttpClient { get; }

		public IBuildingsService BuildingService { get; set; }
		public ICollegesService CollegeService { get; set; }
		public IClassesService ClassService { get; set; }
		public IEmployeesService EmployeeService { get; set; }
		public IPayChecksService PayCheckService { get; set; }
		public IStudentsService StudentService { get; set; }
		public IStudentTeachersService StudentTeacherService { get; set; }

		public ApiClient(HttpClient client)
		{
			this.HttpClient = client;

			if (HttpClient == null)
				return;

			this.BuildingService = new BuildingsService(client);
			this.CollegeService = new CollegesService(client);
			this.ClassService = new ClassesService(client);
			this.EmployeeService = new EmployeesService(client);
			this.PayCheckService = new PayChecksService(client);
			this.StudentService = new StudentsService(client);
			this.StudentTeacherService = new StudentTeachersService(client);
		}
		public void Dispose()
		{
			HttpClient?.Dispose();
		}
	}
}
