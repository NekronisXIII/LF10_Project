using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LF10_Project.MVVM.Models;
using LF10_Project.MVVM.Views;
using LF10_Project.Resources.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Xml.Linq;

namespace LF10_Project.MVVM.ViewModels
{
    public partial class LoginWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private Visibility _visibilityWrongLoginLabel = Visibility.Hidden;

        [ObservableProperty]
        private Brush _borderColorLoginField = new SolidColorBrush(Colors.Black);

        private List<Login> logins = new() { new Login() { Name = "Manfred", Password = "unhashed" }, new Login() { Name = "John", Password = "unhashed" } };

        public LoginWindowViewModel() { }

        [RelayCommand]
        void Login()
        {
            foreach (var login in logins) {
                if (login != null && login.Name.Equals(Name) && login.Password.Equals(Password) ){
                    WindowManager.CloseWindow<LoginWindow>(true);
                    return;
                }
            }
            VisibilityWrongLoginLabel = Visibility.Visible;
            BorderColorLoginField = new SolidColorBrush(Colors.Red);

        }
    }
}
