using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CollegeManagement.ApiService.Services
{
	public class EmployeesService : CrudService<EmployeeDto>, IEmployeesService
	{
		const string url = "api/employees";

		public EmployeesService(HttpClient client) : base (client, url)
		{

		}
	}
}
