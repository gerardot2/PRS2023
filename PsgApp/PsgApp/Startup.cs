using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PsgApp.Services;
using PsgApp.Services.Interfaces;
using PsgApp.UseCases;
using PsgApp.ViewModels;
using Xamarin.Essentials;

namespace PsgApp
{
	public static class Startup
	{
		public static App Init(Action<HostBuilderContext,IServiceCollection> services)
		{
            var host = new HostBuilder()
                .ConfigureHostConfiguration(c =>
                {
                    c.AddCommandLine(new string[] { $"ContentRoot={FileSystem.AppDataDirectory}" });
                })
                .ConfigureServices((c, x) =>
                {
                    services(c, x);
                    ConfigureServices(c, x);
                }).Build();
            App.ServiceProvider = host.Services;
            return App.ServiceProvider.GetService<App>();
		}
		static void ConfigureServices(HostBuilderContext ctx, IServiceCollection services)
		{
			services.AddHttpClient();
			ConfigureServices(services);
            ConfigureCoreServices(services);
            services.AddSingleton<App>();
        }
        private static void ConfigureCoreServices(IServiceCollection services)
        {
            #region Services
            services.AddTransient<IDataService, DataService>();
            services.AddTransient<IUserService, UserService>();
            #endregion

            #region UseCases
            services.AddTransient<GetUsersAsync>();
            #endregion
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            #region ViewModels
            services.AddTransient<BaseViewModel>();
			services.AddTransient<MainViewModel>();
            #endregion
        }
    }
}

