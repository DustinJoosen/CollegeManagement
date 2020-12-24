using CollegeManagement.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Services
{
	public class ServiceCollege<T> : Service<T>, IServiceCollege<T>
	{

		public ServiceCollege(IGenericCollegeRepository<T> genericCollege) : base(genericCollege)
		{

		}
	}
}
