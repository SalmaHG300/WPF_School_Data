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
    /// Interaction logic for DataStructure.xaml
    /// </summary>
    public partial class DataStructure : Window
    {
        public DataStructure()
        {
            InitializeComponent();
            SubjectsMainViewModel subjectMainViewModel = new SubjectsMainViewModel();
            this.DataContext = subjectMainViewModel;
        }

        public static ObservableCollection<Subject> _DataSubject = new ObservableCollection<Subject>
              {
                new Subject("Data Structure") { teachers=new Teachers(){FullName="Amr El-Sayed" },
                students=new List<Student>(){
                new Student() { FullName = "Ali Ahmed", Grade = 50},
                new Student() { FullName = "Ahmed Mohamed",Grade = 30 },
                new Student() { FullName = "Israa Ahmed", Grade =50},
                new Student() { FullName=  "Amira Samy",   Grade = 70},
                new Student() { FullName = "Shehab Mohamed",Grade = 65 },
                new Student() { FullName = "Omar Mokhtar", Grade = 82 },
                new Student() { FullName=  "Arwa Mohsen", Grade = 20 },
                new Student() { FullName = "Tamer Ali", Grade=65 },
                new Student() { FullName = "Mostafa Emad", Grade = 86}
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