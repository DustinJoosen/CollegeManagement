using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public interface IGenericRepository<T>
	{
		Task<T> GetById(int id);
		Task<List<T>> GetAll();
		Task Create(T entity);
		Task Remove(T entity);
		Task Update(T entity);
	}
}
