using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LF10_Project.MVVM.Models;

namespace LF10_Project.MVVM.ViewModels
{
    partial class GradesViewModel : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<Grade> _gradeEntry = new();
        
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

        }

    }
}
