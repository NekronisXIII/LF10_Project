using CommunityToolkit.Mvvm.ComponentModel;
using LF10_Project.MVVM.Models;
using LF10_Project.MVVM.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.ViewModels
{
    internal partial class ScheduleUserControlViewModel : ObservableObject
    {
        #region Members
        [ObservableProperty]
        private ObservableCollection<ScheduleDay> _scheduleDays = new();
        #endregion

        #region Methods
        #region Constructors
        public ScheduleUserControlViewModel() 
        {
            ScheduleSubject emptySubject = new ScheduleSubject(SubjectType.Empty);
            ScheduleSubject breakSubject = new ScheduleSubject(SubjectType.Break);
            ScheduleSubject longBreakSubject = new ScheduleSubject(SubjectType.LongBreak);
            ScheduleSubject subjectGerman1h = new ScheduleSubject("Deutsch", "C109", SubjectType.OneHoure);
            ScheduleSubject subjectEnglish2h = new ScheduleSubject("Englisch", "C102", SubjectType.TwoHours);
            ScheduleSubject subjectPoWi1h = new ScheduleSubject("PoWi", "C103", SubjectType.OneHoure);
            ScheduleSubject subjectSport2h = new ScheduleSubject("Sport", "Sporthalle 1", SubjectType.TwoHours);
            ScheduleSubject subjectHistory1h = new ScheduleSubject("Geschichte", "B103", SubjectType.OneHoure);
            ScheduleSubject subjectHistory2h = new ScheduleSubject("Geschichte", "B103", SubjectType.TwoHours);
            ScheduleSubject subjectPhysic1h = new ScheduleSubject("Physik", "B108", SubjectType.OneHoure);
            ScheduleSubject subjectPhysic2h = new ScheduleSubject("Physik", "B108", SubjectType.TwoHours);
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectGerman1h, subjectPoWi1h, breakSubject, subjectEnglish2h, breakSubject, subjectSport2h, longBreakSubject, subjectPhysic2h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectEnglish2h, breakSubject, subjectPhysic1h, subjectGerman1h, breakSubject, subjectPhysic2h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectPhysic2h, breakSubject, subjectEnglish2h, breakSubject, subjectHistory2h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { emptySubject, emptySubject, breakSubject, subjectHistory2h, breakSubject, subjectGerman1h, subjectHistory1h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectEnglish2h, breakSubject, subjectGerman1h, subjectPoWi1h}));
        }
        #endregion
        #endregion

    }
}
