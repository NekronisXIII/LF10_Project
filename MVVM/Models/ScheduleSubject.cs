using LF10_Project.MVVM.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
    /// <summary>
    /// Model class for holding all information related to a school subject.
    /// </summary>
    public class ScheduleSubject
    {
        #region Methods
        #region Constructors
        /// <summary>
        /// Creates an instance of <see cref="ScheduleSubject"/>.
        /// </summary>
        /// <param name="type">The type of the subject.</param>
        public ScheduleSubject(SubjectType type) 
        {
            Type = type;
        }

		/// <summary>
		/// Creates an instance of <see cref="ScheduleSubject"/>.
		/// </summary>
		/// <param name="name">The name of the subject.</param>
		/// <param name="location">The location of the subject.</param>
		/// <param name="teacher">The teacher of the subject.</param>
		/// <param name="type">The type of the subject.</param>
		public ScheduleSubject(string name, string location,string teacher, SubjectType type) 
        {
            SubjectName = name;
            SubjectLocation = location;
            Teacher = teacher;
            Type = type;
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
