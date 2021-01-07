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
		public LocalStorageManager Storage { get; set; }
		public bool Initialized { get; set; } = false;

		public int CollegeId { get; set; }

		public AppState(ApiClient apiClient, LocalStorageManager localStorageManager)
		{
			this.ApiClient = apiClient;
			this.Storage = localStorageManager;
			this.CollegeId = 1;
		}
	}
}
