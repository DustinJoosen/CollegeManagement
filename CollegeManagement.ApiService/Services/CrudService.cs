using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CollegeManagement.Infra.Interfaces;
using Newtonsoft.Json;

namespace CollegeManagement.ApiService.Services
{
	class CrudService<T> : ICrudService<T> where T : class, IBase
	{
		private HttpClient client;
		private readonly string url;

		public CrudService(HttpClient client, string url)
		{
			this.client = client;
			this.url = url;
		}

		public async Task<List<T>> GetAll(CancellationToken cancellationToken = default)
		{
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				var reponse = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

				if (!reponse.IsSuccessStatusCode)
					return null;

				var contentStream = await reponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<List<T>>(contentStream);
			}
			catch(Exception ex)
			{
				return null;
			}
		}

		public async Task<T> GetById(int id, CancellationToken cancellationToken = default)
		{
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				var reponse = await client.GetAsync($"{url}/{id}", HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

				if (!reponse.IsSuccessStatusCode)
					return null;

				var contentStream = await reponse.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(contentStream);
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public async Task<T> Create(T dto)
		{
			try
			{
				var json = JsonConvert.SerializeObject(dto);
				var content = new StringContent(json, Encoding.UTF8, "application/json");
				var response = await client.PostAsync(url, content);

				if (response.IsSuccessStatusCode)
					return default;

				var contentStream = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(contentStream);
			}
			catch(Exception ex)
			{
				return null;
			}
		}

		public async Task<T> Update(T dto)
		{
			try
			{
				var json = JsonConvert.SerializeObject(dto);
				var content = new StringContent(json, Encoding.UTF8, "application/json");
				var response = await client.PutAsync(url, content);

				if (response.IsSuccessStatusCode)
					return default;

				var contentStream = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T>(contentStream);
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public async Task<bool> Remove(T dto)
		{
			try
			{
				var response = await client.DeleteAsync($"{url}/{dto.Id}");
				return response.IsSuccessStatusCode;
			}
			catch(Exception ex)
			{
				return false;
			}
		}

	}
}
