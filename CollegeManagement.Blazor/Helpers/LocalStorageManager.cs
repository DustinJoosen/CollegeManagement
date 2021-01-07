using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Blazor.Helpers
{
	public class LocalStorageManager
	{
		private ILocalStorageService storage;
		public LocalStorageManager(ILocalStorageService localStorage)
		{
			this.storage = localStorage;
		}

		public async Task<T> Get<T>(string key)
		{
			return await this.storage.GetItemAsync<T>(key);
		}

		public async Task<string> GetAsString(string key)
		{
			return await this.storage.GetItemAsStringAsync(key);
		}

		public async Task Set(string key, string value)
		{
			await this.storage.SetItemAsync<string>(key, value);
		}

		public async Task Set(string key, int value)
		{
			await this.storage.SetItemAsync<int>(key, value);
		}

		public async Task Set(string key, bool value)
		{
			await this.storage.SetItemAsync<bool>(key, value);
		}

		public async Task Set(string key, decimal value)
		{
			await this.storage.SetItemAsync<Decimal>(key, value);
		}

		public async Task Remove(string key)
		{
			await this.storage.RemoveItemAsync(key);
		}

		public async Task Clear()
		{
			await this.storage.ClearAsync();
		}

		public async Task<bool> Contains(string key)
		{
			return await this.storage.ContainKeyAsync(key);
		}
	}
}
