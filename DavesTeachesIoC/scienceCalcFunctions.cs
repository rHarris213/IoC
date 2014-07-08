using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavesTeachesIoC
{
    public class scienceCalcFunctions : IScienceCalcFunctions, ICalcFunctions
    {
        
        public double CalculateCircumference(int bum1)
        {
            return Math.PI * Math.Pow((double)bum1, 2.0);
        }

        public int AddFunction(int bum1, int bum2)
        {
            return 1;
        }

        public int SubtractFunction(int bum1, int bum2)
        {
            return 2;
        }

        public int MultiplyFunction(int bum1, int bum2)
        {
            return 3;
        }

        public int DivisionFunction(int bum1, int bum2)
        {
            return 4;
        }
    }
}
