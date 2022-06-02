using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    public class Caculator
    {

        public void GetRefValue(ref int Number)
        {
            Console.WriteLine("NumbeRef is: " + ++Number);
        }

        internal void GetOutValue(out int numberOut)
        {
            numberOut = 1;
            Console.WriteLine("numberOut is: " + ++numberOut);
        }
    }
}
