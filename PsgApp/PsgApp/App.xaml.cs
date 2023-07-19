using System;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsgApp
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public App ()
        {
            //ServiceCollection sc = new ServiceCollection();
            //ServiceProvider = sc.BuildServiceProvider();
            InitializeComponent();
            MainPage = new MainPage();
        }

        private void RegisterServices()
        {
            
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

