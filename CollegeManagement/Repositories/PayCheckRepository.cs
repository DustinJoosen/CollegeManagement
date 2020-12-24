using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class PayCheckRepository : GenericCollegeRepository<PayCheck>, IPayCheckRepository
	{
		public PayCheckRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
