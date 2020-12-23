using CollegeManagement.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Services
{
	public class CollegeService<T> : Service<T>, ICollegeService<T>
	{

		public CollegeService(IGenericCollegeRepository<T> genericCollege) : base(genericCollege)
		{

		}
	}
}
