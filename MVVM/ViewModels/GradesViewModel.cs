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
            GradeEntry.Add(new Grade(6, "Deutsch", "Robert.James@web.de"));
            GradeEntry.Add(new Grade(4, "English", "Michelle.Redneck@web.de"));
        }

    }
}
