using CollegeManagement.ApiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Blazor.Helpers
{
	public class AppState
	{
		public ApiClient ApiClient { get; set; }
		public bool Initialized { get; set; } = false;

		public AppState(ApiClient apiClient)
		{
			this.ApiClient = apiClient;
		}
	}
}
