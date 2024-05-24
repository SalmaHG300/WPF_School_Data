using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_PROJECT.Model;
using WPF_PROJECT.View;
using WPF_PROJECT.ViewModel;

namespace WPF_PROJECT.Command
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
      
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {            
            if (parameter.ToString() == "Students")
            {
                viewModel.SelectedViewModel = new StudentMainViewModel();
            }
            else if (parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new MainViewModel();
            }
            else if (parameter.ToString() == "Teachers")
            {
                viewModel.SelectedViewModel = new TeacherMainViewModel();
            }
            else if (parameter.ToString() == "Subjects")
            {
                viewModel.SelectedViewModel = new SubjectsMainViewModel();
            }
            else if (parameter.ToString() == "Calculator")
            {
                viewModel.SelectedViewModel = new CalculatorMainViewModel();
            }
            else if (parameter.ToString() == null)
            {
                viewModel.SelectedViewModel = new HomePageViewModel();
            }
            else
            {
                viewModel.SelectedViewModel =  new HomePageViewModel();
            }

        }
    }
}
