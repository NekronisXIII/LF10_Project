using LF10_Project.MVVM.Services;
using LF10_Project.MVVM.Services.Interfaces;
using LF10_Project.MVVM.ViewModels;
using LF10_Project.MVVM.Views;
using LF10_Project.Resources.Utils;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace LF10_Project
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		#region Members
		private IServiceProvider _serviceProvider;
		#endregion

		#region Methods
		#region Constructors
		public App()
		{
			_serviceProvider = ConfigureServices();
		}
		#endregion

		#region Private methods
		public static IServiceProvider ConfigureServices()
		{
			var services = new ServiceCollection();

			services.AddTransient<MainWindowViewModel>();
			services.AddTransient<MainWindow>();
			services.AddTransient<GradesViewModel>();
			services.AddTransient<TeacherListViewModel>();
			services.AddTransient<LoginWindowViewModel>();
			services.AddTransient<ScheduleUserControlViewModel>();
			services.AddSingleton<IAccountService, LoginService>();

			return services.BuildServiceProvider();
		}
		#endregion


		#region Override methods
		private void OnStartup(object sender, StartupEventArgs e)
		{
			Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            var service = _serviceProvider.GetRequiredService<IAccountService>();
            bool result = WindowManager.ShowDialog<LoginWindow>(App.Instance.ServiceProvider.GetRequiredService<LoginWindowViewModel>()) ?? false;
			if (result)
			{
                MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
                MainWindow.Show();
				return;
            }
			
			Current.Shutdown(0);
		}
		#endregion
		#endregion

		#region Properties
		public static App Instance => (App) Current;

		public IServiceProvider ServiceProvider => _serviceProvider;
		#endregion
	}
}
