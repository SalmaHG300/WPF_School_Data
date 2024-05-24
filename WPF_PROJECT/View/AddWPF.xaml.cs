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
using System.Xml.Linq;
using WPF_PROJECT.Command;
using WPF_PROJECT.Model;
using WPF_PROJECT.ViewModel;

namespace WPF_PROJECT.View
{
    /// <summary>
    /// Interaction logic for AddWPF.xaml
    /// </summary>
    public partial class AddWPF : Window
    {
        public AddWPF()
        {
            InitializeComponent();
            SubjectsMainViewModel subjectMainViewModel = new SubjectsMainViewModel();
            this.DataContext = subjectMainViewModel;
          
        }
        public static ObservableCollection<Subject> _DataSubject = new ObservableCollection<Subject>
        {
                new Subject("WPF") { teachers=new Teachers(){FullName="Ahmed Gameel" }, 
                students=new List<Student>(){
                new Student() { FullName = "Ali Ahmed", Grade = 92},
                new Student() { FullName = "Ahmed Mohamed",Grade = 50 },
                new Student() { FullName = "Israa Ahmed", Grade = 76},
                new Student() { FullName=  "Amira Samy",   Grade = 90},
                new Student() { FullName = "Shehab Mohamed",Grade = 60 },
                new Student() { FullName = "Omar Mokhtar", Grade = 80 },
                new Student() { FullName=  "Arwa Mohsen", Grade = 72 },
                new Student() { FullName = "Tamer Ali", Grade=20 },
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
