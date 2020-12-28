using CollegeManagement.Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CollegeManagement.ApiService.Services
{
	public class PayChecksService : CrudService<PayCheckDto>, IPayChecksService
	{
		const string url = "api/paychecks";

		public PayChecksService(HttpClient client) : base (client, url)
		{

		}
	}
}
