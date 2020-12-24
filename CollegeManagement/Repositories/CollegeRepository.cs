using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class CollegeRepository : GenericRepository<College>, ICollegeRepository
	{
		public CollegeRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
