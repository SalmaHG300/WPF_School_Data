using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_PROJECT.Command;

namespace WPF_PROJECT.Model
{
    public class UserManager : BaseViewModel
    {
        public static ObservableCollection<Student> _DataStudents = new ObservableCollection<Student>
              {
                new Student() { FullName = "Ali Ahmed",    Gender="Male",Age=25 , Grade = 90,Email="aliahmed@gmail.com"},
                new Student() { FullName = "Ahmed Mohamed",Gender="Male", Age=25,Grade = 30,Email="ahmedmohamed@gmail.com" },
                new Student() { FullName = "Israa Ahmed",  Gender="Female", Age=24,Grade = 89,Email="israahmed@gmail.com"},
                new Student() { FullName=  "Amira Samy",   Gender="Female",Age=24, Grade = 66,Email="amirasamy@gmail.com" },
                new Student() { FullName = "Shehab Mohamed",Gender="Male",Age=25,Grade = 45,Email="shejabmohamed@gmail.com" },
                new Student() { FullName = "Omar Mokhtar",Gender="Male",Age=24, Grade = 95,Email="omarmokhtar@gmail.com" },
                new Student() { FullName=  "Arwa Mohsen",Gender="Female",Age=23, Grade = 82,Email="arwamohsen@gmail.com" },
                new Student() { FullName = "Tamer Ali",Gender="Male", Age=25, Grade=60, Email="tamerali@gmail.com" },
                new Student() { FullName = "Mostafa Emad",Gender="Male",Age=24, Grade = 30,Email="mostafaemad@gmail.com" } 
        }; 
    
         

        public static ObservableCollection<Student> GetStudents()
        {
            return _DataStudents;
        }
        public static void AddStudent(Student student)
        {
            _DataStudents.Add(student);
        }
        public static ObservableCollection<Teachers> _DataTeachers = new ObservableCollection<Teachers>
              {
                new Teachers() {  FullName = "Ahmed Gameel", Gender="Male",Age=35 ,Subject="WPF & CAD-API",Email="ahmedgameel@gmail.com",Salary=15000,Time="Full Time"},
                new Teachers() {  FullName="AboAuf", Gender="Male",Age=50,Subject="C# & OOP",Email="waalayman@gmail.com" ,Salary=25000,Time="Part Time"},
                new Teachers() {  FullName = "Amr El-Sayed", Gender="Female",Age=26,Subject="BIM",Email="amrsayed@gmail.com",Salary=11000,Time="Part Time"},
                new Teachers() {  FullName = "Ahmed Mohie", Gender="Female",Age=45,Subject = "Data Structure",Email ="agmedmohie@gmail.com",Salary=20000,Time="Full Time"},
                new Teachers() {  FullName = "Ahmed Adel", Gender="Female",Age=45,Subject = "Data Base",Email ="ahmeahdel@gmail.com",Salary=20000,Time="Psrt Time"}
              };

        public static ObservableCollection<Teachers> GetTeachers()
        {
            return _DataTeachers;
        }
        public static void AddTeacher(Teachers teacher)
        {
            _DataTeachers.Add(teacher);
        }

    }
}
