using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class BuildingRepository : GenericCollegeRepository<Building>, IBuildingRepository
	{
		public BuildingRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
