using CollegeManagement.Api.Models;
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
	}
}
