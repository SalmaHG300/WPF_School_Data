using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_PROJECT.Command;
using static WPF_PROJECT.Model.Student;

namespace WPF_PROJECT.Model
{
    public class Student :BaseViewModel
    {

        public Student() { }
        public Student( string FullName, string Gender, int Age, int Grade,string Email)
        {           
            this.FullName = FullName;              
            this.Age = Age;
            this.Gender = Gender;
            this.Grade = Grade;
            this.Email = Email;
        }
       

        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Grade { get; set; }
        public int Age {  get; set; }
        public string Email { get; set; }
        public bool IsGraduated
        {
            set { this.Grade = Grade; }
            get
            {
                if (Grade >= 50) return true;
                else return false;
            }
        }
        public override string ToString()
        {
            return "Name " + FullName ;
        }
    }
}
