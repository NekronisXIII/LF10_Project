using LF10_Project.MVVM.Models;
using LF10_Project.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Services
{
    internal class LoginService : IAccountService
    {
        public Login? CurrentUser { get; private set; }

        public bool LoginUser(Login login)
        {
			CurrentUser = login;
            return true;
        }
    }
}
