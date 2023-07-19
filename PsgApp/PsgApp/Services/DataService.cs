using System;
using System.Net.Http;
using PsgApp.Services.Interfaces;
using Refit;

namespace PsgApp.Services
{
	public class DataService : IDataService
	{
		HttpClient _client;
		public DataService() 
		{
			_client = new HttpClient() { BaseAddress = new Uri("https://random-data-api.com/api/v2") };
		}
		public T GetRestService<T>()
		{
			return RestService.For<T>(_client);
		}
	}
}

