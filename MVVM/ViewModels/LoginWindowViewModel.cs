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
		private string _name = "Manfred Müller";
		
		private string _password = "unhashed";

		private IAccountService _accountService;

		[ObservableProperty]
		private Visibility _visibilityWrongLoginLabel = Visibility.Hidden;

		[ObservableProperty]
		private Brush _borderColorLoginField = new SolidColorBrush(Colors.Black);

		private List<Login> _logins = new();

		public LoginWindowViewModel(IAccountService accountService) {
			_accountService = accountService;
		}

		[RelayCommand]
		void Login(object parameter)
		{
			_logins.Add(new Login("Manfred", "Müller", "unhashed")
			{
				Age = 16,
				Birthday = new DateOnly(2007, 9, 12),
				EMail = "Manfred.Mueller@t-online.de",
				Class = "10b",
				School = "Max-Planck-Gymnasium",
				ResidanceLand = "Deutschland",
				ResidanceCity = "Hamburg"
			});

			_logins.Add(new Login("John", "Schmidt", "unhashed")
			{
				Age = 17,
				Birthday = new DateOnly(2006, 2, 5),
				EMail = "John.Schmidt@gmail.com",
				Class = "11a",
				School = "Albert-Einstein-Gymnasium",
				ResidanceLand = "Deutschland",
				ResidanceCity = "Berlin"
			});

			var pwbox = parameter as PasswordBox;
			string pw = pwbox.Password;

			foreach (var login in _logins) {
				if (login != null && login.FullName.Equals(Name) && login.Password.Equals(_password) ){
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
