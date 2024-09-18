using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LF10_Project.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.ViewModels
{
	internal partial class MainWindowViewModel : ObservableObject
	{
        #region Members
        [ObservableProperty]
        private bool _optionsOpen;

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
        #endregion
        #endregion
    }
}
