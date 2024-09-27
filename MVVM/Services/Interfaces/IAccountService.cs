using LF10_Project.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Services.Interfaces
{
    /// <summary>
    /// Interface for the account related services.
    /// </summary>
    public interface IAccountService
    {
        #region Methods
        /// <summary>
        /// Login the provided user.
        /// </summary>
        /// <param name="login">The provided user.</param>
        /// <returns></returns>
        public bool LoginUser(Login login);
		#endregion

		#region Properties
		public Login CurrentUser { get; }
		#endregion
	}
}
