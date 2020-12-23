using CollegeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		protected DbSet<T> _entity;
		protected ApplicationDbContext _context;

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
			_entity = context.Set<T>();
		}

		public virtual async Task<List<T>> GetAll()
		{
			return await this._entity.ToListAsync();
		}

		public virtual async Task<T> GetById(int id)
		{
			return await this._entity.FindAsync(id);
		}

		public virtual async Task Create(T entity)
		{
			await this._entity.AddAsync(entity);
			await this._context.SaveChangesAsync();
		}

		public virtual async Task Update(T entity)
		{
			this._context.Entry(entity).State = EntityState.Modified;
			await this._context.SaveChangesAsync();
		}

		public virtual async Task Remove(T entity)
		{
			_entity.Remove(entity);
			await this._context.SaveChangesAsync();
		}
	}
}
