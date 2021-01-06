using CollegeManagement.Infra.Dtos;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CollegeManagement.ApiService.Services
{
	public interface IEmployeesService : ICrudService<EmployeeDto>
	{
		Task<List<StudentDto>> GetStudents(int id, CancellationToken cancellationToken = default);
	}
}