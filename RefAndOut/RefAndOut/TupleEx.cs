using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutAndTuple
{
    internal class TupleEx
    {

        public void CheckTuple1()
        {
            //Ex1
            (int Number1, decimal Number2, string Name) model = (1, 2, "A");

            Console.WriteLine(model.Number1 + "," + model.Number2 + ", " + model.Name);

        }

        //Ex2
        public (int number , string name) CheckTuple2()
        {
            return (1, "faezeh");
        }
    }
       
}
