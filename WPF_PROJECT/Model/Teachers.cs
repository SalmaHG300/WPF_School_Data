using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_PROJECT.Model
{
    public class Teachers
    {
        public Teachers() { }
        public Teachers(string FullName, string Gender, int Age, string Subject, string Email,int Salary, string Time)
        {
            this.FullName = FullName;
            this.Age = Age;
            this.Gender = Gender;            
            this.Email = Email;
            this.Subject= Subject;
            this.Salary = Salary;
            this.Time = Time;
        }

        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Time { get; set; }

        public override string ToString()
        {
            return "Name " + FullName;
        }
    }
}
