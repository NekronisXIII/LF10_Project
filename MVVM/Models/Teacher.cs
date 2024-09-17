using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
    partial class Teacher
    {
        public Teacher(string firstName, string lastName, string mailAdress) {
            FirstName = firstName;
            LastName = lastName;    
            MailAdress = mailAdress;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MailAdress { get; set; }


    }
}
