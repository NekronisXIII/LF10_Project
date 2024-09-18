using LF10_Project.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Services.Interfaces
{
    public interface IAccountService
    {
        public string Username { get; }

        public bool LoginUser(Login login);
    }
}
