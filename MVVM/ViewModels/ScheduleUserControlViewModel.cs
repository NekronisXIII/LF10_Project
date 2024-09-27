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
    /// <summary>
    /// View model class for school schedule related views.
    /// </summary>
    internal partial class ScheduleUserControlViewModel : ObservableObject
    {
        #region Members
        [ObservableProperty]
        private ObservableCollection<ScheduleDay> _scheduleDays = new();
        #endregion

        #region Methods
        
        #region Constructors
        /// <summary>
        /// Creates an instance of <see cref="ScheduleUserControlViewModel"/>.
        /// </summary>
        public ScheduleUserControlViewModel() 
        {
            List<string> teacherNames = generateTeacherNames();
			ScheduleSubject emptySubject = new ScheduleSubject(SubjectType.Empty);
            ScheduleSubject breakSubject = new ScheduleSubject(SubjectType.Break);
            ScheduleSubject longBreakSubject = new ScheduleSubject(SubjectType.LongBreak);
            ScheduleSubject subjectGerman1h = new ScheduleSubject("Deutsch", "C109", teacherNames[9], SubjectType.OneHoure);
            ScheduleSubject subjectEnglish2h = new ScheduleSubject("Englisch", "C102", teacherNames[3], SubjectType.TwoHours);
            ScheduleSubject subjectPoWi1h = new ScheduleSubject("Politik", "C103", teacherNames[5], SubjectType.OneHoure);
            ScheduleSubject subjectSport2h = new ScheduleSubject("Sport", "Sporthalle 1", teacherNames[2], SubjectType.TwoHours);
            ScheduleSubject subjectHistory1h = new ScheduleSubject("Geschichte", "B103", teacherNames[1], SubjectType.OneHoure);
            ScheduleSubject subjectHistory2h = new ScheduleSubject("Geschichte", "B103", teacherNames[1], SubjectType.TwoHours);
            ScheduleSubject subjectPhysic1h = new ScheduleSubject("Physik", "B108", teacherNames[7], SubjectType.OneHoure);
            ScheduleSubject subjectPhysic2h = new ScheduleSubject("Physik", "B108", teacherNames[7], SubjectType.TwoHours);
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectGerman1h, subjectPoWi1h, breakSubject, subjectEnglish2h, breakSubject, subjectSport2h, longBreakSubject, subjectPhysic2h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectEnglish2h, breakSubject, subjectPhysic1h, subjectGerman1h, breakSubject, subjectPhysic2h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectPhysic2h, breakSubject, subjectEnglish2h, breakSubject, subjectHistory2h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { emptySubject, emptySubject, breakSubject, subjectHistory2h, breakSubject, subjectGerman1h, subjectHistory1h }));
            ScheduleDays.Add(new ScheduleDay(new List<ScheduleSubject>() { subjectEnglish2h, breakSubject, subjectGerman1h, subjectPoWi1h}));
        }
		#endregion

		#region Private methods
		private List<string> generateTeacherNames()
		{
			TeacherListViewModel teacherListViewModel = new TeacherListViewModel();
			List<Teacher> teacher = teacherListViewModel.SetTeacher().ToList();
			return teacher.Select(t => t.LastName).ToList();
		}
		#endregion
		#endregion
	}
}
