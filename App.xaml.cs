using LF10_Project.MVVM.ViewModels;
using LF10_Project.MVVM.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
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
		private static IServiceProvider ConfigureServices()
		{
			var services = new ServiceCollection();

			services.AddTransient<MainWindowViewModel>();
			services.AddTransient<MainWindow>();

			return services.BuildServiceProvider();
		}
		#endregion

		#region Override methods
		protected override void OnStartup(StartupEventArgs e)
		{
			_serviceProvider.GetRequiredService<MainWindow>().Show();

			base.OnStartup(e);
		}
		#endregion
		#endregion

		#region Properties
		public static App Instance => (App) Current;

		public IServiceProvider ServiceProvider => _serviceProvider;
		#endregion
	}
}
