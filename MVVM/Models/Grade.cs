using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
    internal class Grade
    {

        public Grade(int gradeValue, string subject, string mailAdress) { 
            GradeValue = gradeValue;
            Subject = subject;
            MailAdress = mailAdress;    
        }

        public int GradeValue { get; set; }
        
        public string Subject { get; set; }

        public string MailAdress { get; set; }
    }
}
