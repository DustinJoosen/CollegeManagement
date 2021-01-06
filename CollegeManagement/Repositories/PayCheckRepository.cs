using CollegeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
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

		public override async Task<List<PayCheck>> GetAll()
		{
			return await this._entity
				.Where(s => s.CollegeId == _collegeId)
				.Include(s => s.Employee)
				.ToListAsync();
		}
	}
}
