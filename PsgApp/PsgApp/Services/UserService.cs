using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PsgApp.Models;
using PsgApp.Services.Interfaces;

namespace PsgApp.Services
{
	public class UserService : IUserService
	{
		IDataService _dataService;
		public UserService(IDataService dataService)
		{
			_dataService = dataService;
		}

		public async Task<List<User>> GetUsersAsync(int size)
		{
			try
			{
				var resp = await _dataService.GetRestService<IUsersClient>().GetUsers(size);
				return resp;

			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}

