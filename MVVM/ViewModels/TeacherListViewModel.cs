using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LF10_Project.MVVM.Models;
using CommunityToolkit.Mvvm.Input;
using System.Text.RegularExpressions;
using System.Windows.Media;

namespace LF10_Project.MVVM.ViewModels
{
    /// <summary>
    /// View model class for teacher related views.
    /// </summary>
    partial class TeacherListViewModel : ObservableObject
    {
		#region Members
		[ObservableProperty]
		private ObservableCollection<Teacher> _teacher = new();

		[ObservableProperty]
		private ObservableCollection<Teacher> _filteredTeacher = new();

		[ObservableProperty]
		private string _search = "";

		[ObservableProperty]
		private string _matches = "";

		[ObservableProperty]
		private SolidColorBrush _matchesBrush;
		#endregion

		#region Methods
		#region Constructors
		/// <summary>
		/// Creates an instance of <see cref="TeacherListViewModel"/>.
		/// </summary>
		public TeacherListViewModel()
		{
			Teacher = SetTeacher();
			List<Teacher> sortedTeachers = Teacher.OrderBy(t => t.FirstName).ToList();

			Teacher = new(sortedTeachers);
			FilteredTeacher = new(Teacher);
			UpdateMeshes(sortedTeachers.Count());
		}
		#endregion

		#region Partial methods
		partial void OnSearchChanged(string value)
		{
			SearchList();
		}
		#endregion

		#region Private methods
		[RelayCommand]
		private void SearchList()
		{
			FilteredTeacher = Teacher;
			//Need to cast to list cause of Findmethod
			List<Teacher> teachers = new List<Teacher>(FilteredTeacher);

			teachers = teachers.FindAll(
				delegate (Teacher teacher)
				{
					return teacher.FirstName.ToLower().Contains(Search.ToLower()) ||
					teacher.LastName.ToLower().Contains(Search.ToLower()) ||
					teacher.MailAdress.ToLower().Contains(Search.ToLower());
					;
				}
			);
			FilteredTeacher = new ObservableCollection<Teacher>(teachers);
			UpdateMeshes(teachers.Count());
		}

		private void UpdateMeshes(int count)
		{
			if (count > 0)
			{
				Matches = "Suchergebnisse: " + count;
				MatchesBrush = new SolidColorBrush(Colors.LightGreen);
				return;
			}
			Matches = "Keine Suchergebnisse";
			MatchesBrush = new SolidColorBrush(Colors.Red);
		}
		#endregion

		#region Public methods
		public ObservableCollection<Teacher> SetTeacher()
		{
			ObservableCollection<Teacher> teacher = new ObservableCollection<Teacher>();
			teacher.Add(new Teacher("Emma", "Stone", "Emma.Stone@gmail.com"));
			teacher.Add(new Teacher("John", "Doe", "John.Doe@gmail.com"));
			teacher.Add(new Teacher("Olivia", "Smith", "Olivia.Smith@gmail.com"));
			teacher.Add(new Teacher("Liam", "Johnson", "Liam.Johnson@gmail.com"));
			teacher.Add(new Teacher("Sophia", "Brown", "Sophia.Brown@gmail.com"));
			teacher.Add(new Teacher("Noah", "Williams", "Noah.Williams@gmail.com"));
			teacher.Add(new Teacher("Isabella", "Jones", "Isabella.Jones@gmail.com"));
			teacher.Add(new Teacher("Mason", "Garcia", "Mason.Garcia@gmail.com"));
			teacher.Add(new Teacher("Ava", "Martinez", "Ava.Martinez@gmail.com"));
			teacher.Add(new Teacher("Logan", "Rodriguez", "Logan.Rodriguez@gmail.com"));
			teacher.Add(new Teacher("Mia", "Hernandez", "Mia.Hernandez@gmail.com"));
			teacher.Add(new Teacher("Lucas", "Lopez", "Lucas.Lopez@gmail.com"));
			teacher.Add(new Teacher("Charlotte", "Gonzalez", "Charlotte.Gonzalez@gmail.com"));
			teacher.Add(new Teacher("Elijah", "Wilson", "Elijah.Wilson@gmail.com"));
			teacher.Add(new Teacher("Amelia", "Anderson", "Amelia.Anderson@gmail.com"));
			teacher.Add(new Teacher("James", "Thomas", "James.Thomas@gmail.com"));
			teacher.Add(new Teacher("Harper", "Taylor", "Harper.Taylor@gmail.com"));
			teacher.Add(new Teacher("Alexander", "Moore", "Alexander.Moore@gmail.com"));
			teacher.Add(new Teacher("Evelyn", "Jackson", "Evelyn.Jackson@gmail.com"));
			teacher.Add(new Teacher("Ethan", "Martin", "Ethan.Martin@gmail.com"));
			teacher.Add(new Teacher("Abigail", "Lee", "Abigail.Lee@gmail.com"));
			teacher.Add(new Teacher("Benjamin", "Perez", "Benjamin.Perez@gmail.com"));
			teacher.Add(new Teacher("Sofia", "White", "Sofia.White@gmail.com"));
			teacher.Add(new Teacher("Henry", "Thompson", "Henry.Thompson@gmail.com"));
			teacher.Add(new Teacher("Ella", "Sanchez", "Ella.Sanchez@gmail.com"));
			teacher.Add(new Teacher("Sebastian", "Clark", "Sebastian.Clark@gmail.com"));
			teacher.Add(new Teacher("Avery", "Ramirez", "Avery.Ramirez@gmail.com"));
			teacher.Add(new Teacher("Jackson", "Lewis", "Jackson.Lewis@gmail.com"));
			teacher.Add(new Teacher("Scarlett", "Robinson", "Scarlett.Robinson@gmail.com"));
			teacher.Add(new Teacher("Oliver", "Walker", "Oliver.Walker@gmail.com"));
			teacher.Add(new Teacher("Emily", "Young", "Emily.Young@gmail.com"));
			return teacher;
		}
		#endregion
		#endregion
    }
}
