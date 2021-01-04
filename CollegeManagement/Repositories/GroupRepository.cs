using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class GroupRepository : GenericCollegeRepository<Group>, IGroupRepository
	{
		public GroupRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
