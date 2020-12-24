using CollegeManagement.Api.Models;
using CollegeManagement.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Services
{
	public class ClassService : ServiceCollege<Class>, IClassService
	{
		public ClassService(IClassRepository repos) : base (repos)
		{

		}
	}
}
