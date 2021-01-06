using CollegeManagement.Infra.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollegeManagement.ApiService.Services
{
	public class EmployeesService : CrudService<EmployeeDto>, IEmployeesService
	{
		const string url = "api/employees";
		private HttpClient client;

		public EmployeesService(HttpClient client) : base (client, url)
		{
			this.client = client;
		}

		public async Task<List<StudentDto>> GetStudents(int id, CancellationToken cancellationToken = default)
		{
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				var reponse = await client.GetAsync($"{url}/{id}/students", HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

				if (!reponse.IsSuccessStatusCode)
					return null;

				var contentStream = await reponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<StudentDto>>(contentStream);
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
