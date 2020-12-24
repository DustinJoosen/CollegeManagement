using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class ClassRepository : GenericCollegeRepository<Class>, IClassRepository
	{
		public ClassRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
