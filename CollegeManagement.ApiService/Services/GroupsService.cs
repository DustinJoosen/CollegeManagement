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
	public class GroupsService : CrudService<GroupDto>, IClassesService
	{
		const string url = "api/groups";
		private HttpClient client;

		public GroupsService(HttpClient client) : base (client, url)
		{
			this.client = client;
		}

		public async Task<ClassParticipantsDto> GetParticipants(int id, CancellationToken cancellationToken = default)
		{
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				var reponse = await client.GetAsync($"{url}/{id}/participants", HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

				if (!reponse.IsSuccessStatusCode)
					return null;

				var contentStream = await reponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<ClassParticipantsDto>(contentStream);
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
