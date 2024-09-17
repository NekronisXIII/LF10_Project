using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
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
        #endregion

        #region Methods
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
