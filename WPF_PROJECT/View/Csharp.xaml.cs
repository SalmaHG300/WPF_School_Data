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
    /// Interaction logic for Csharp.xaml
    /// </summary>
    public partial class Csharp : Window
    {
        public Csharp()
        {
            InitializeComponent();
            SubjectsMainViewModel subjectMainViewModel = new SubjectsMainViewModel();
            this.DataContext = subjectMainViewModel;
        }

        public static ObservableCollection<Subject> _DataSubject = new ObservableCollection<Subject>
              {
                new Subject("C#") { teachers=new Teachers(){FullName="Amr El-Sayed" },
                students=new List<Student>(){
                new Student() { FullName = "Ali Ahmed", Grade = 60},
                new Student() { FullName = "Ahmed Mohamed",Grade = 72 },
                new Student() { FullName = "Israa Ahmed", Grade =22},
                new Student() { FullName=  "Amira Samy",   Grade = 90},
                new Student() { FullName = "Shehab Mohamed",Grade = 30 },
                new Student() { FullName = "Omar Mokhtar", Grade = 50 },
                new Student() { FullName=  "Arwa Mohsen", Grade = 68 },
                new Student() { FullName = "Tamer Ali", Grade=89 },
                new Student() { FullName = "Mostafa Emad", Grade = 95 }
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