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
        private ObservableCollection<Grade> _testEntry = new();
        
        public GradesViewModel()
        {
            TestEntry.Add(new Grade(6,"Deutsch","lehrer@web.de"));
        }

    }
}
