using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DavesTeachesIoC
{
    public class CalcFunctions : ICalcFunctions
    {
        private ICalcDatabase _ICalcDatabase;
        public CalcFunctions(ICalcDatabase ICalcDatabase)
        {
            _ICalcDatabase = ICalcDatabase;
        }

        public int AddFunction(int bum1, int bum2)
        {
            var result = bum1 + bum2;
           _ICalcDatabase.AddNumberToDB(result);
           return result;
        }

        public int SubtractFunction(int bum1, int bum2)
        {
            var result = bum1 - bum2;
            _ICalcDatabase.AddNumberToDB(result);
            return result;
        }

        public int MultiplyFunction(int bum1, int bum2)
        {
            var result = bum1 * bum2;
            _ICalcDatabase.AddNumberToDB(result);
            return result;
        }

        public int DivisionFunction(int bum1, int bum2)
        {
            var result = bum1 / bum2;
            _ICalcDatabase.AddNumberToDB(result);
            return result;
        }
    }
}
