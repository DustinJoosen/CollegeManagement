using CollegeManagement.Api.Models;
using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public interface IEmployeeRepository : IGenericCollegeRepository<Employee>
	{
		Task<List<Student>> GetStudents(int id);
	}
}
