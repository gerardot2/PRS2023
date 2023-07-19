using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PsgApp.Models;

namespace PsgApp.Services.Interfaces
{
	public interface IUserService
	{
		Task<List<User>> GetUsersAsync(int size);
	}
}

