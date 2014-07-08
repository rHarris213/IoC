using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavesTeachesIoC
{
    public interface ICalc 
    {
        int ScienceAdd(int bum1, int bum2);


        int ScienceSubtract(int bum1, int bum2);
        
        int Add(int bum1, int bum2);


        int Subtract(int bum1, int bum2);


        int Multiply(int bum1, int bum2);




        int Division(int bum1, int bum2);


    }
}
