using CollegeManagement.Api.Models;
using CollegeManagement.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Services
{
	public class StudentService : ServiceCollege<Student>, IStudentService
	{
		public StudentService(IStudentRepository repos) : base (repos)
		{

		}
	}
}
