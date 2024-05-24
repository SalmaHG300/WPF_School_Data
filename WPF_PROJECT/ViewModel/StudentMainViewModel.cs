using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_PROJECT.Command;
using WPF_PROJECT.Model;
using WPF_PROJECT.View;


namespace WPF_PROJECT.ViewModel
{
    public class StudentMainViewModel : BaseViewModel 
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        #region Properties

        public ObservableCollection<Student> Students { get; set; }

        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }

        public MyCommand ShowAddStudent { get; set; }     

        public MyCommand AddStudent { get; set; }

        public MyCommand RemoveStudent { get; set; }
        #endregion
     
        #region Constructor
        public StudentMainViewModel()
        {

            Students = UserManager.GetStudents();
            ShowAddStudent= new MyCommand(ShowWindowAddStudent,CanShowWindow);
            AddStudent = new MyCommand(AddStudentToCollection, CanAdd);
            RemoveStudent = new MyCommand(RemoveStudentFromCollection, CanRemove);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindowAddStudent(object obj)
        {
            AddStudent addStudentwin = new AddStudent();
            addStudentwin.Show();
        }
        #endregion


        public void AddStudentToCollection(object parameter)
        {
            UserManager.AddStudent(new Student() {FullName=FullName,Age=Age,Gender=Gender,Email= Email,Grade = Grade });       

        }

        public bool CanAdd(object parameter)
        {
            return true;

        }

        public void RemoveStudentFromCollection(object parameter)
        {
            Students.Remove(SelectedStudent);
        }

        public bool CanRemove(object parameter)
        {
            return true;
        }
      
    }
}
