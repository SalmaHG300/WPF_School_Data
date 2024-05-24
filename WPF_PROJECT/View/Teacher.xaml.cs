using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_PROJECT.Model;

namespace WPF_PROJECT.View
{
    /// <summary>
    /// Interaction logic for Teacher.xaml
    /// </summary>
    public partial class Teacher : UserControl
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teachers_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();

        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Teachers.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var teacher = (Teachers)obj;
            return teacher.FullName.IndexOf(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;

        }
    }
}
