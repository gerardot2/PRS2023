using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PsgApp.ViewModels;
using Xamarin.Forms;

namespace PsgApp
{
    public partial class MainPage : ContentPage
    {
        MainViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent();
            _viewModel = App.ServiceProvider.GetService<MainViewModel>();
            BindingContext = _viewModel;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}

