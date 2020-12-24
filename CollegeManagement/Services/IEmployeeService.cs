using CollegeManagement.Api.Models;
using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Services
{
	public interface IEmployeeService : IServiceCollege<Employee>
	{
		Task<List<Student>> GetStudents(int id);
	}
}
