using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class StudentRepository : GenericCollegeRepository<Student>, IStudentRepository
	{
		public StudentRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
