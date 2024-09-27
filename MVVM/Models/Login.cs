using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF10_Project.MVVM.Models
{
	/// <summary>
	/// Model class which holds information of every login possible in this system.
	/// </summary>
    public class Login
    {
		#region Methods
		#region Constructors
		/// <summary>
		/// Creates an instance of <see cref="Login"/>.
		/// </summary>
		/// <param name="firstName">The first name of the user.</param>
		/// <param name="lastName">The last name of the user.</param>
		/// <param name="password">The password of the user.</param>
		public Login(string firstName, string lastName, string password)
		{
			FirstName = firstName;
			LastName = lastName;
			Password = password;
		}
		#endregion
		#endregion

		#region Properties
		public string FirstName { get; }
        public string LastName { get; }

        public string FullName => String.Join(' ', FirstName, LastName);
        public string Password { get; }

		public int Age { get; set; }
		public DateOnly Birthday { get; set; }
		public string EMail { get; set; }
		public string Class { get; set; }
		public string School { get; set; }
		public string ResidanceLand { get; set; }
		public string ResidanceCity { get; set; }
		public string Residance => String.Join(", ", ResidanceCity, ResidanceLand);
		#endregion
	}
}
