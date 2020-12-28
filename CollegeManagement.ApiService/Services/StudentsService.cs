using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CollegeManagement.ApiService.Services
{
	public class StudentsService : CrudService<StudentDto>, IStudentsService
	{
		const string url = "api/students";

		public StudentsService(HttpClient client) : base (client, url)
		{

		}
	}
}
