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
            Teacher.Add(new Teacher("Emma", "Stone", "Emma.Stone@gmail.com"));
            Teacher.Add(new Teacher("John", "Doe", "John.Doe@gmail.com"));
            Teacher.Add(new Teacher("Olivia", "Smith", "Olivia.Smith@gmail.com"));
            Teacher.Add(new Teacher("Liam", "Johnson", "Liam.Johnson@gmail.com"));
            Teacher.Add(new Teacher("Sophia", "Brown", "Sophia.Brown@gmail.com"));
            Teacher.Add(new Teacher("Noah", "Williams", "Noah.Williams@gmail.com"));
            Teacher.Add(new Teacher("Isabella", "Jones", "Isabella.Jones@gmail.com"));
            Teacher.Add(new Teacher("Mason", "Garcia", "Mason.Garcia@gmail.com"));
            Teacher.Add(new Teacher("Ava", "Martinez", "Ava.Martinez@gmail.com"));
            Teacher.Add(new Teacher("Logan", "Rodriguez", "Logan.Rodriguez@gmail.com"));
            Teacher.Add(new Teacher("Mia", "Hernandez", "Mia.Hernandez@gmail.com"));
            Teacher.Add(new Teacher("Lucas", "Lopez", "Lucas.Lopez@gmail.com"));
            Teacher.Add(new Teacher("Charlotte", "Gonzalez", "Charlotte.Gonzalez@gmail.com"));
            Teacher.Add(new Teacher("Elijah", "Wilson", "Elijah.Wilson@gmail.com"));
            Teacher.Add(new Teacher("Amelia", "Anderson", "Amelia.Anderson@gmail.com"));
            Teacher.Add(new Teacher("James", "Thomas", "James.Thomas@gmail.com"));
            Teacher.Add(new Teacher("Harper", "Taylor", "Harper.Taylor@gmail.com"));
            Teacher.Add(new Teacher("Alexander", "Moore", "Alexander.Moore@gmail.com"));
            Teacher.Add(new Teacher("Evelyn", "Jackson", "Evelyn.Jackson@gmail.com"));
            Teacher.Add(new Teacher("Ethan", "Martin", "Ethan.Martin@gmail.com"));
            Teacher.Add(new Teacher("Abigail", "Lee", "Abigail.Lee@gmail.com"));
            Teacher.Add(new Teacher("Benjamin", "Perez", "Benjamin.Perez@gmail.com"));
            Teacher.Add(new Teacher("Sofia", "White", "Sofia.White@gmail.com"));
            Teacher.Add(new Teacher("Henry", "Thompson", "Henry.Thompson@gmail.com"));
            Teacher.Add(new Teacher("Ella", "Sanchez", "Ella.Sanchez@gmail.com"));
            Teacher.Add(new Teacher("Sebastian", "Clark", "Sebastian.Clark@gmail.com"));
            Teacher.Add(new Teacher("Avery", "Ramirez", "Avery.Ramirez@gmail.com"));
            Teacher.Add(new Teacher("Jackson", "Lewis", "Jackson.Lewis@gmail.com"));
            Teacher.Add(new Teacher("Scarlett", "Robinson", "Scarlett.Robinson@gmail.com"));
            Teacher.Add(new Teacher("Oliver", "Walker", "Oliver.Walker@gmail.com"));
            Teacher.Add(new Teacher("Emily", "Young", "Emily.Young@gmail.com"));

        }

    }
}
