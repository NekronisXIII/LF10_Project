using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LF10_Project.MVVM.Views;
using LF10_Project.Resources.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LF10_Project.MVVM.ViewModels
{
    public partial class LoginWindowViewModel: ObservableObject
    {
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _password;

        public LoginWindowViewModel() { }

        [RelayCommand]
        void Login()
        {
            WindowManager.CloseWindow<LoginWindow>(true);
        }
    }
}
