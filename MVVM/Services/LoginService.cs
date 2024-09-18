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
        public string Username { get; private set; } = string.Empty;

        public bool LoginUser(Login login)
        {
            Username = login.Name;
            return true;
        }
    }
}
