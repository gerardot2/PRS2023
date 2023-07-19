using System;
namespace PsgApp.Services.Interfaces
{
	public interface IDataService
	{
        T GetRestService<T>();
    }
}

