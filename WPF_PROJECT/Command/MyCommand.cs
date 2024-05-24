using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_PROJECT.Command
{
    public class MyCommand :ICommand
    {
        public event EventHandler CanExecuteChanged;

        #region Constructor
        public Action<object> Excute { get; set; }

        public Predicate<object> CanExcute { get; set; }

        public MyCommand(Action<object> _excute, Predicate<object> _canExcute)
        {
            this.Excute = _excute;

            this.CanExcute = _canExcute;
        }
        #endregion
        public bool CanExecute(object parameter)
        {
            return this.CanExcute(parameter);
        }

        public void Execute(object parameter)
        {
            Excute(parameter);
        }
    }
}
