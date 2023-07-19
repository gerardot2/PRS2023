using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PsgApp.Models;
using Refit;

namespace PsgApp.Services.Interfaces
{
	public interface IUsersClient
	{
		[Get("/users")]
		Task<List<User>> GetUsers([AliasAs("size")] int size);
	}
}

