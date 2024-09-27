using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LF10_Project.MVVM.Services.Interfaces;
using LF10_Project.MVVM.Views;
using LF10_Project.Resources.Utils;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LF10_Project.MVVM.ViewModels
{
    /// <summary>
    /// View model class for the main window.
    /// </summary>
    internal partial class MainWindowViewModel : ObservableObject
    {
        #region Members
        [ObservableProperty]
        private bool _optionsOpen;

        [ObservableProperty]
        private bool _userMenu = false;

        private IAccountService _accountService;

        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private ObservableCollection<string> _typeOfSchool = new ObservableCollection<string>() { "Sonderschule", "Hauptschule", "Realschule", "Gymnasium" };

        private const string UnknownInfo = "unbekannt";

		[ObservableProperty]
		private string _class = UnknownInfo;
		[ObservableProperty]
		private string _school = UnknownInfo;
		[ObservableProperty]
		private string _eMail = UnknownInfo;
		[ObservableProperty]
		private string _residance = UnknownInfo;
		[ObservableProperty]
		private string _age = UnknownInfo;
		[ObservableProperty]
		private string _birthday = UnknownInfo;
		#endregion

		#region Methods
		/// <summary>
		/// Creates an instance of <see cref="MainWindowViewModel"/>.
		/// </summary>
		/// <param name="accountService">A singleton instance of an accout service.</param>
		public MainWindowViewModel(IAccountService accountService) {
            _accountService = accountService;
            Username = _accountService.CurrentUser.FullName;
            Class = _accountService.CurrentUser.Class;
            School = _accountService.CurrentUser.School;
            EMail = _accountService.CurrentUser.EMail;
            Residance = _accountService.CurrentUser.Residance;
            Age = _accountService.CurrentUser.Age.ToString();
            Birthday = _accountService.CurrentUser.Birthday.ToString();
        }
        #endregion

        #region Private methods

        [RelayCommand]
        private void OpenOptions()
        {
            OptionsOpen = true;
        }

        [RelayCommand]
        private void CloseOptions()
        {
            OptionsOpen = false;
        }

        [RelayCommand]
        private void ToggleUserMenu()
        {
            UserMenu = !UserMenu;
        }

		[RelayCommand]
		void Logout()
		{
			App.Current.MainWindow.Hide();
			IServiceProvider _serviceProvider = App.ConfigureServices();

			var service = _serviceProvider.GetRequiredService<IAccountService>();
			bool result = WindowManager.ShowDialog<LoginWindow>(App.Instance.ServiceProvider.GetRequiredService<LoginWindowViewModel>()) ?? false;
			if (result)
			{
				App.Current.MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
				App.Current.MainWindow.Show();
				return;
			}

			App.Current.Shutdown(0);
		}
		#endregion
	}
}
