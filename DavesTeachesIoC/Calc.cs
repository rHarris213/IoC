using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavesTeachesIoC
{
    public class Calc : ICalc
    {
        private ICalcFunctions _calcFunctions;
        private ICalcFunctions _scientificFunctions;
        
     

        public Calc(ICalcFunctions calcFunctions, ICalcFunctions siCalcFunctions)
        {
            _calcFunctions = calcFunctions;
            _scientificFunctions = siCalcFunctions;
        }

        public int Add(int bum1, int bum2)
        {
            return _calcFunctions.AddFunction(bum1, bum2);
            
        }

        public int Subtract(int bum1, int bum2)
        {
            return _calcFunctions.SubtractFunction(bum1, bum2);
        }

        public int Multiply(int bum1, int bum2)
        {
            return _calcFunctions.MultiplyFunction(bum1, bum2);
        }

        public int Division(int bum1, int bum2)
        {
            return _calcFunctions.DivisionFunction(bum1, bum2);
        }

        public int ScienceAdd(int bum1, int bum2)
        {
            return _scientificFunctions.AddFunction(bum1, bum2);
        }

        public int ScienceSubtract(int bum1, int bum2)
        {
            throw new NotImplementedException();
        }
    }
}
