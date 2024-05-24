using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_PROJECT.Model
{
    public class ArithmeticOperators
    {
        public bool Addition { get; set; }
        public bool Subtraction { get; set; }
        public bool Division { get; set; }
        public bool Multiplication { get; set; }

        public ArithmeticOperators()
        {
            Addition = false;
            Subtraction = false;
            Division = false;
            Multiplication = false;
        }
    }
}
