using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CollegeManagement.ApiService.Services
{
	public class CollegesService : CrudService<CollegeDto>, ICollegesService
	{
		const string url = "api/colleges";

		public CollegesService(HttpClient client) : base (client, url)
		{

		}
	}
}
