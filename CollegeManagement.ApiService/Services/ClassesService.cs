using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CollegeManagement.ApiService.Services
{
	public class ClassesService : CrudService<ClassDto>, IClassesService
	{
		const string url = "api/classes";

		public ClassesService(HttpClient client) : base (client, url)
		{

		}
	}
}
