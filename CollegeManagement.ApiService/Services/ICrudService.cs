using CollegeManagement.Infra.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CollegeManagement.ApiService.Services
{
	internal interface ICrudService<T> where T : IBase
	{
		Task<List<T>> GetAll(CancellationToken cancellationToken = default);
		Task<T> GetById(int id, CancellationToken cancellationToken = default);
		Task<T> Create(T dto);
		Task<T> Update(T dto);
		Task<bool> Remove(T dto);
	}
}