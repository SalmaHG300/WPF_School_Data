using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_PROJECT.Command;
using WPF_PROJECT.View;

namespace WPF_PROJECT.ViewModel
{
    public class MainViewModel :BaseViewModel
    {        
        
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set {
                 _selectedViewModel = value; //new MainViewModel();
                OnPropertyChanged();
            }
        }
        public ICommand UpdateViewCommand { get; set; }
        public MainViewModel()
        {
            SelectedViewModel = new HomePageViewModel();

            UpdateViewCommand = new UpdateViewCommand(this);

        }

    }
}
