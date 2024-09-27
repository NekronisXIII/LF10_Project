using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
    /// <summary>
    /// Model class for holding all teacher related information.
    /// </summary>
    partial class Teacher
    {
		#region Methods
		#region Constructors
		/// <summary>
		/// Creates an instance of <see cref="Teacher"/>.
		/// </summary>
		/// <param name="firstName">The first name of the teacher.</param>
		/// <param name="lastName">The last name of the teacher.</param>
		/// <param name="mailAdress">The e-mail of the teacher.</param>
		public Teacher(string firstName, string lastName, string mailAdress)
		{
			FirstName = firstName;
			LastName = lastName;
			MailAdress = mailAdress;
		}
		#endregion
		#endregion


		#region Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string MailAdress { get; set; }
		#endregion
	}
}
