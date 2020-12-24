using CollegeManagement.Api.Models;
using CollegeManagement.Infra.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class EmployeeRepository : GenericCollegeRepository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(ApplicationDbContext context) : base(context)
		{

		}

		public async Task<List<Student>> GetStudents(int id)
		{
			return await this._context.StudentTeachers
				.Where(s => s.CollegeId == _collegeId)
				.Where(s => s.TeacherId == id)
				.Select(s => s.Student)
				.ToListAsync();
		}
	}
}
