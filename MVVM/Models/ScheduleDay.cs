using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
    public class ScheduleDay
    {
        #region Methods
        #region Constructors
        public ScheduleDay(List<ScheduleSubject> subjects) 
        {
            ScheduleSubjects = new ObservableCollection<ScheduleSubject>(subjects);
        }
        #endregion
        #endregion

        #region Properties
        public ObservableCollection<ScheduleSubject> ScheduleSubjects { get; set; } = new();
        #endregion
    }
}
