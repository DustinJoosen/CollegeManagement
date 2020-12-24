using CollegeManagement.Api.Models;
using CollegeManagement.Api.Repositories;
using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Services
{
	public class EmployeeService : ServiceCollege<Employee>, IEmployeeService
	{
		private IEmployeeRepository repos;
		public EmployeeService(IEmployeeRepository repos) : base (repos)
		{
			this.repos = repos;
		}

		public async Task<List<Student>> GetStudents(int id)
		{
			return await repos.GetStudents(id);
		}
	}
}
