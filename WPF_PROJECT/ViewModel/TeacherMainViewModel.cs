using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_PROJECT.Command;
using WPF_PROJECT.Model;
using WPF_PROJECT.View;

namespace WPF_PROJECT.ViewModel
{
    public class TeacherMainViewModel:BaseViewModel
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public string Time { get; set; }

        #region Properties

        public ObservableCollection<Teachers> Teachers { get; set; }

        private Teachers _selectedTeacher;

        public Teachers SelectedTeacher
        {
            get { return _selectedTeacher; }
            set
            {
                _selectedTeacher = value;
                OnPropertyChanged();
            }
        }


        public MyCommand ShowAddTeacher { get; set; }


        public MyCommand AddTeacher { get; set; }

        public MyCommand RemoveTeacher { get; set; }
        #endregion

        #region Constructor
        public TeacherMainViewModel()
        {

            Teachers = UserManager.GetTeachers();
            ShowAddTeacher = new MyCommand(ShowWindowAddTeacher, CanShowWindow);
            AddTeacher = new MyCommand(AddTeacherToCollection, CanAdd);
            RemoveTeacher = new MyCommand(RemoveTeacherFromCollection, CanRemove);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindowAddTeacher(object obj)
        {
            AddTeacher addTeacherwin = new AddTeacher();
            addTeacherwin.Show();
        }
        #endregion


        public void AddTeacherToCollection(object parameter)
        {
            UserManager.AddTeacher(new Teachers() { FullName = FullName, Age = Age, Gender = Gender, Email = Email, 
                Subject=Subject, Salary=Salary, Time=Time });

        }


        public bool CanAdd(object parameter)
        {
            return true;

        }

        public void RemoveTeacherFromCollection(object parameter)
        {
            Teachers.Remove(SelectedTeacher);
        }

        public bool CanRemove(object parameter)
        {
            return true;
        }
    }
}
