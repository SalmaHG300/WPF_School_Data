using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_PROJECT.View;
using WPF_PROJECT.ViewModel;

namespace WPF_PROJECT.Command
{
    public class ButtonPressCommand : ICommand
    {

        private CalculatorMainViewModel _viewModel;

        public CalculatorMainViewModel viewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; }
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object button)
        {
            viewModel.GetPressedButton(button.ToString());
        }

        public ButtonPressCommand(CalculatorMainViewModel calculator)
        {
            viewModel = calculator;
        }
    }
}

