using CollegeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class StudentRepository : GenericCollegeRepository<Student>, IStudentRepository
	{
		public StudentRepository(ApplicationDbContext context) : base(context)
		{

		}

		public override async Task<Student> GetById(int id)
		{
			return await this._entity
				.Where(s => s.CollegeId == _collegeId)
				.Include(s => s.Group)
				.Include(s => s.Building)
				.SingleOrDefaultAsync(s => s.Id == id);
		}
	}
}
