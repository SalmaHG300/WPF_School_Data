using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_PROJECT.Command;
using WPF_PROJECT.Model;

namespace WPF_PROJECT.Model
{
    public class Subject:BaseViewModel
    {
        public string subjectName;
        public Teachers teachers;
        public List<Student> students;

        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; OnPropertyChanged(); }
        }

        public Teachers Teachers
        {
            get { return teachers; }
            set { teachers = value; OnPropertyChanged(); }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; OnPropertyChanged(); }
        }

        public Subject()
        {
            Students = new List<Student>();
        }

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
            Students = new List<Student>();
        }
     
    }
}
//public class Subject
//{
//    public string SubjectName { get; set; }
//    public string TtName { get; set; }
//    public int Grade { get; set; }
//    public Teachers teachers { get; set; }
//    public List<Student> students { get; set; }
//    public Subject(string subjectName, string TtName, List<Student> students)
//    {
//        this.SubjectName = subjectName;
//        TtName = teachers.FullName;
//        students = new List<Student>();

//    }
//}