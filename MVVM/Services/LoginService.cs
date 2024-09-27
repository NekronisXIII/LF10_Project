using LF10_Project.MVVM.Models;
using LF10_Project.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Services
{
    /// <summary>
    /// Service class for logging in users.
    /// </summary>
    internal class LoginService : IAccountService
    {
		#region Methods
		#region Public methods
		/// <summary>
		/// Logs in the privided user.
		/// </summary>
		/// <param name="login"></param>
		/// <returns></returns>
		public bool LoginUser(Login login)
		{
			CurrentUser = login;
			return true;
		}
		#endregion
		#endregion

		#region Properties
		public Login? CurrentUser { get; private set; }
		#endregion
	}
}
