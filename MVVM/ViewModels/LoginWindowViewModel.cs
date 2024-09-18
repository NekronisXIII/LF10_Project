using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LF10_Project.MVVM.Models;
using LF10_Project.MVVM.Services.Interfaces;
using LF10_Project.MVVM.Views;
using LF10_Project.Resources.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;

namespace LF10_Project.MVVM.ViewModels
{
    public partial class LoginWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = "Manfred";
        [ObservableProperty]
        private string _password = "unhashed";

        private IAccountService _accountService;

        [ObservableProperty]
        private Visibility _visibilityWrongLoginLabel = Visibility.Hidden;

        [ObservableProperty]
        private Brush _borderColorLoginField = new SolidColorBrush(Colors.Black);

        private List<Login> logins = new() { new Login() { Name = "Manfred", Password = "unhashed" }, new Login() { Name = "John", Password = "unhashed" } };

        public LoginWindowViewModel(IAccountService accountService) {
            _accountService = accountService;
        }

        [RelayCommand]
        void Login(object parameter)
        {
            var pwbox = parameter as PasswordBox;
            string pw = pwbox.Password;

            foreach (var login in logins) {
                if (login != null && login.Name.Equals(Name) && login.Password.Equals(Password) ){
                    _accountService.LoginUser(login);
                    WindowManager.CloseWindow<LoginWindow>(true);
                    return;
                }
            }
            VisibilityWrongLoginLabel = Visibility.Visible;
            BorderColorLoginField = new SolidColorBrush(Colors.Red);

        }
    }
}
