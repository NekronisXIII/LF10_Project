using LF10_Project.MVVM.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
    public class ScheduleSubject
    {
        #region Methods
        #region Constructors
        public ScheduleSubject(SubjectType duration) 
        {
            Type = duration;
        }

        public ScheduleSubject(string name, string location,string teacher, SubjectType duration) 
        {
            SubjectName = name;
            SubjectLocation = location;
            Teacher = teacher;
            Type = duration;
        }
        #endregion
        #endregion

        #region Properties
        public string SubjectName { get; set; } = String.Empty;
        public string SubjectLocation { get; set; } = String.Empty;

        public string Teacher {  get; set; } = String.Empty;

        public SubjectType Type { get;}
        #endregion
    }
}
