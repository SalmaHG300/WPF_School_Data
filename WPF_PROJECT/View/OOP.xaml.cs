using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_PROJECT.Model;
using WPF_PROJECT.ViewModel;

namespace WPF_PROJECT.View
{
    /// <summary>
    /// Interaction logic for OOP.xaml
    /// </summary>
    public partial class OOP : Window
    {
        public OOP()
        {
            InitializeComponent();
            SubjectsMainViewModel subjectMainViewModel = new SubjectsMainViewModel();
            this.DataContext = subjectMainViewModel;
        }
      
        public static ObservableCollection<Subject> _DataSubject = new ObservableCollection<Subject>
              {
                new Subject("OOP") { teachers=new Teachers(){FullName="AboAuf" },
                students=new List<Student>(){
                new Student() { FullName = "Ali Ahmed", Grade = 89},
                new Student() { FullName = "Ahmed Mohamed",Grade = 70 },
                new Student() { FullName = "Israa Ahmed", Grade = 28},
                new Student() { FullName=  "Amira Samy",   Grade = 30},
                new Student() { FullName = "Shehab Mohamed",Grade = 75 },
                new Student() { FullName = "Omar Mokhtar", Grade = 85 },
                new Student() { FullName=  "Arwa Mohsen", Grade = 96 },
                new Student() { FullName = "Tamer Ali", Grade=70 },
                new Student() { FullName = "Mostafa Emad", Grade = 65 }
                } }
                  
        };
        public static ObservableCollection<Subject> GetSubject()
        {

            return _DataSubject;
        }
        public static void AddSubject(Subject subject)
        {
            _DataSubject.Add(subject);
        }
       

       
    }
}