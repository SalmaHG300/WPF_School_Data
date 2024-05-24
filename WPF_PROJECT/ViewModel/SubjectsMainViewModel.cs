using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using WPF_PROJECT.Command;
using WPF_PROJECT.Model;
using WPF_PROJECT.View;

namespace WPF_PROJECT.ViewModel
{
    public class SubjectsMainViewModel:BaseViewModel
    {       
        public List<Student> students { get; set; }
        public ObservableCollection<Subject> WPFsubjects { get; set; }
        public ObservableCollection<Subject> OOPsubjects { get; set; }
        public ObservableCollection<Subject> BIMsubjects { get; set; }
        public ObservableCollection<Subject> DataStrsubjects { get; set; }
        public ObservableCollection<Subject> DataBasesubjects { get; set; }
        public ObservableCollection<Subject> CADsubjects { get; set; }
        public ObservableCollection<Subject> Csubjects { get; set; }

        public MyCommand ShowSubject { get; set; }
        
        public SubjectsMainViewModel()
        {                      
           WPFsubjects = AddWPF.GetSubject();
           OOPsubjects = OOP.GetSubject();
           BIMsubjects = BIM.GetSubject();
           DataStrsubjects= DataStructure.GetSubject();
           DataBasesubjects= DataBase.GetSubject();
           CADsubjects = CADAPI.GetSubject();
           Csubjects = Csharp.GetSubject();
           ShowSubject = new MyCommand(ShowWindowAddSubject, CanShowWindow);
        }
     
        private bool CanShowWindow(object obj)
        {
            return true;
        }     

        private void ShowWindowAddSubject(object obj)
        {
            if (obj.ToString() == "WPF")
            {
                AddWPF ShowSubject = new AddWPF();
                ShowSubject.Show();
            }
            else if (obj.ToString() == "OOP")
            {
                OOP ShowSubject = new OOP();
                ShowSubject.Show();
            }
            else if (obj.ToString() == "BIM")
            {
                BIM ShowSubject = new BIM();
                ShowSubject.Show();
            }
            else if (obj.ToString() == "DataStructure")
            {
                DataStructure ShowSubject = new DataStructure();
                ShowSubject.Show();
            }
            else if (obj.ToString() == "DataBase")
            {
                DataBase ShowSubject = new DataBase();
                ShowSubject.Show();
            }
            else if (obj.ToString() == "C#")
            {
                Csharp ShowSubject = new Csharp();
                ShowSubject.Show();
            }
            else if (obj.ToString() == "CAD-API")
            {
                CADAPI ShowSubject = new CADAPI();
                ShowSubject.Show();
            }

        }      

        public bool CanAdd(object parameter)
        {
            return true;
        }   
    }
}
