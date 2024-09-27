using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
    /// <summary>
    /// Model class for holding all subjects for a scheduled day.
    /// </summary>
    public class ScheduleDay
    {
        #region Methods
        #region Constructors
        /// <summary>
        /// Creates an instance of <see cref="ScheduleDay"/>.
        /// </summary>
        /// <param name="subjects">All list of subjects that planed for the day.</param>
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
