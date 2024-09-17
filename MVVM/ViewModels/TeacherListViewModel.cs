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
    partial class TeacherListViewModel : ObservableObject
    {


        [ObservableProperty]
        private ObservableCollection<Teacher> _teacher = new();
        public TeacherListViewModel()
        {
            Teacher.Add(new Teacher("Robert", "James", "Robert.James@gmail.com"));
            Teacher.Add(new Teacher("Michelle", "Redneck", "Michelle.Redneck@gmail.com"));
        }

    }
}
