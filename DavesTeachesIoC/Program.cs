using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavesTeachesIoC
{
    class Program
    {
        static void Main(string[] args)
        {

            var calcObj = new CalcContainer().resolveUnity();

            
            Console.WriteLine(calcObj.Add(2, 3));
            Console.WriteLine(calcObj.Subtract(2, 3));
            Console.WriteLine(calcObj.Multiply(2, 3));
            Console.WriteLine(calcObj.Division(2, 3));
            Console.WriteLine(calcObj.ScienceAdd(2, 3));

            Console.ReadKey();

          

        }
    }
}
