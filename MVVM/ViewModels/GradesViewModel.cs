﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LF10_Project.MVVM.Models;
using static System.Reflection.Metadata.BlobBuilder;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media;

namespace LF10_Project.MVVM.ViewModels
{
    /// <summary>
    /// View model class for school grades related view.
    /// </summary>
    partial class GradesViewModel : ObservableObject
    {
		#region Members
		[ObservableProperty]
		private ObservableCollection<Grade> _gradeEntry = new();

		[ObservableProperty]
		private ObservableCollection<Grade> _filteredGradeEntry = new();

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
		/// Creates an instance of <see cref="GradesViewModel"/>.
		/// </summary>
		public GradesViewModel()
		{
			GradeEntry.Add(new Grade(5, "Mathematik", "Emma.Stone@web.de"));
			GradeEntry.Add(new Grade(3, "Geschichte", "John.Doe@web.de"));
			GradeEntry.Add(new Grade(2, "Biologie", "Olivia.Smith@web.de"));
			GradeEntry.Add(new Grade(1, "Chemie", "Liam.Johnson@web.de"));
			GradeEntry.Add(new Grade(6, "Physik", "Sophia.Brown@web.de"));
			GradeEntry.Add(new Grade(4, "Kunst", "Noah.Williams@web.de"));
			GradeEntry.Add(new Grade(5, "Sport", "Isabella.Jones@web.de"));
			GradeEntry.Add(new Grade(3, "Musik", "Mason.Garcia@web.de"));
			GradeEntry.Add(new Grade(2, "Französisch", "Ava.Martinez@web.de"));
			GradeEntry.Add(new Grade(1, "Geographie", "Logan.Rodriguez@web.de"));
			GradeEntry.Add(new Grade(6, "Politik", "Mia.Hernandez@web.de"));
			GradeEntry.Add(new Grade(4, "Informatik", "Lucas.Lopez@web.de"));
			GradeEntry.Add(new Grade(5, "Latein", "Charlotte.Gonzalez@web.de"));
			GradeEntry.Add(new Grade(3, "Deutsch", "Elijah.Wilson@web.de"));
			GradeEntry.Add(new Grade(2, "English", "Amelia.Anderson@web.de"));
			GradeEntry.Add(new Grade(1, "Mathematik", "James.Thomas@web.de"));
			GradeEntry.Add(new Grade(6, "Geschichte", "Harper.Taylor@web.de"));
			GradeEntry.Add(new Grade(4, "Biologie", "Alexander.Moore@web.de"));
			GradeEntry.Add(new Grade(5, "Chemie", "Evelyn.Jackson@web.de"));
			GradeEntry.Add(new Grade(3, "Physik", "Ethan.Martin@web.de"));
			GradeEntry.Add(new Grade(2, "Kunst", "Abigail.Lee@web.de"));
			GradeEntry.Add(new Grade(1, "Sport", "Benjamin.Perez@web.de"));
			GradeEntry.Add(new Grade(6, "Musik", "Sofia.White@web.de"));
			GradeEntry.Add(new Grade(4, "Französisch", "Henry.Thompson@web.de"));
			GradeEntry.Add(new Grade(5, "Geographie", "Ella.Sanchez@web.de"));
			GradeEntry.Add(new Grade(3, "Politik", "Sebastian.Clark@web.de"));
			GradeEntry.Add(new Grade(2, "Informatik", "Avery.Ramirez@web.de"));
			GradeEntry.Add(new Grade(1, "Latein", "Jackson.Lewis@web.de"));
			GradeEntry.Add(new Grade(6, "Deutsch", "Scarlett.Robinson@web.de"));
			GradeEntry.Add(new Grade(4, "English", "Oliver.Walker@web.de"));
			List<Grade> sortedGrade = GradeEntry.OrderBy(t => t.Subject).ToList();

			GradeEntry = new(sortedGrade);

			FilteredGradeEntry = GradeEntry;

			UpdateMeshes(sortedGrade.Count());
		}
		#endregion

		#region Private methods
		private void SearchList(string Search)
		{
			FilteredGradeEntry = GradeEntry;
			//Need to cast to list cause of Findmethod
			List<Grade> grades = new List<Grade>(FilteredGradeEntry);

			grades = grades.FindAll(
				delegate (Grade grade)
				{
					return grade.Subject.ToLower().Contains(Search.ToLower()) ||
					grade.MailAdress.ToLower().Contains(Search.ToLower()) ||
					grade.GradeValue.ToString().Contains(Search);
					;
				}
			);
			FilteredGradeEntry = new ObservableCollection<Grade>(grades);


			UpdateMeshes(grades.Count());

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

		#region Partal methods
		partial void OnSearchChanged(string value)
		{
			SearchList(value);
		}
		#endregion
		#endregion
	}
}
