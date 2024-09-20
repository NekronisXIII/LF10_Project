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

        #endregion

        #region Methods

        public MainWindowViewModel(IAccountService accountService) {
            _accountService = accountService;
            Username = _accountService.Username;
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

        #endregion
        [RelayCommand]
        void Logout()
        {
            App.Current.MainWindow.Close();
            IServiceProvider _serviceProvider = App.ConfigureServices();
            App.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
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
    }
}
