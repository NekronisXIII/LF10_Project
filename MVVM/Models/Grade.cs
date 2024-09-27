using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{   
    /// <summary>
    /// Model class for holding all school grade related information.
    /// </summary>
    internal class Grade
    {
		#region Methods
		#region Constructor
		/// <summary>
		/// Creates an instance of <see cref="Grade"/>.
		/// </summary>
		/// <param name="gradeValue">The grade value.</param>
		/// <param name="subject">The related subject to the grade.</param>
		/// <param name="mailAdress">The address of the teacher who gave the grade.</param>
		public Grade(int gradeValue, string subject, string mailAdress)
		{
			GradeValue = gradeValue;
			Subject = subject;
			MailAdress = mailAdress;
		}
		#endregion
		#endregion

		#region Properties
		public int GradeValue { get; set; }

		public string Subject { get; set; }

		public string MailAdress { get; set; }
		#endregion
	}
}
