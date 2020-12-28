using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CollegeManagement.ApiService.Services
{
	public class StudentTeachersService : CrudService<StudentTeacherDto>, IStudentTeachersService
	{
		const string url = "api/studentteachers";

		public StudentTeachersService(HttpClient client) : base (client, url)
		{

		}
	}
}
