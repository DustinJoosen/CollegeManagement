using System;
using System.Net.Http;

namespace CollegeManagement.ApiService
{
	public class ApiService : IDisposable
	{
		public HttpClient HttpClient { get; }

		public ApiService(HttpClient client)
		{
			this.HttpClient = client;
		}
		public void Dispose()
		{
			HttpClient?.Dispose();
		}
	}
}
