using CollegeManagement.Infra.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace CollegeManagement.ApiService.Services
{
	public interface IClassesService : ICrudService<GroupDto>
	{
		Task<ClassParticipantsDto> GetParticipants(int id, CancellationToken cancellationToken = default);
	}
}