using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using PsgApp.Models;
using PsgApp.UseCases;
using Refit;

namespace PsgApp.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		GetUsersAsync _getUsers;
		public MainViewModel(GetUsersAsync getUsersAsync)
		{
			_getUsers = getUsersAsync;
			Items = new ObservableCollection<User>();
		}

		ObservableCollection<User> _items;
		public ObservableCollection<User> Items
		{
			get => _items;
			set
			{
				SetProperty(ref _items, value);
			}
		}
		internal async void OnAppearing()
		{
			await SetData();
		}

        private async Task SetData()
        {
			try
			{
				var result = await _getUsers.Invoke(20);
				if (result != null)
				{
					Items = new ObservableCollection<User>(result);
				}
			}
			catch (Exception ex)
			{

			}
        }
    }

}

