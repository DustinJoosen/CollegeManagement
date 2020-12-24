using CollegeManagement.Api.Models;
using CollegeManagement.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class GenericCollegeRepository<T> : GenericRepository<T>, IGenericCollegeRepository<T> where T :  class , ICollege
	{

		public int _collegeId;

		public GenericCollegeRepository(ApplicationDbContext context) : base(context)
		{
			_collegeId = 1;
		}

		public override async Task<List<T>> GetAll()
		{
			return await _entity
				.Where(s => s.CollegeId == _collegeId).ToListAsync();
		}

		public override async Task<T> GetById(int id)
		{
			var entity = await base.GetById(id);
			return entity?.CollegeId == this._collegeId ? entity : null;
		}

		public override async Task Create(T entity)
		{
			entity.CollegeId = _collegeId;
			await base.Create(entity);
		}

		public override async Task Update(T entity)
		{
			if(entity.CollegeId != _collegeId)
				return;

			await base.Update(entity);
		}

		public override async Task Remove(T entity)
		{
			if (entity.CollegeId != _collegeId)
				return;

			await base.Remove(entity);
		}

	}
}
