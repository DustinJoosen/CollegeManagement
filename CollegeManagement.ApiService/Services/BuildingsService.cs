using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CollegeManagement.ApiService.Services
{
	public class BuildingsService : CrudService<BuildingDto>, IBuildingsService
	{
		const string url = "api/buildings";

		public BuildingsService(HttpClient client) : base (client, url)
		{

		}
	}
}
