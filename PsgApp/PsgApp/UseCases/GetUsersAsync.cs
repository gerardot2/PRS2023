using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PsgApp.Models;
using PsgApp.Services.Interfaces;

namespace PsgApp.UseCases
{
	public class GetUsersAsync
	{
		IUserService _userService;
		public	GetUsersAsync(IUserService userService)
		{
			_userService = userService;
		}
		public async Task<List<User>> Invoke(int size)
		{
			try
			{
				var result = await _userService.GetUsersAsync(size);
				return result;

			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}

