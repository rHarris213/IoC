using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;



namespace DavesTeachesIoC
{
    public class CalcContainer
    {
        public ICalc resolveUnity()
        {
            var calcObj = new UnityContainer();
            calcObj.RegisterType<ICalc, Calc>(new InjectionConstructor(typeof(CalcFunctions), typeof(scienceCalcFunctions)));
            
            calcObj.RegisterType<ICalcFunctions, CalcFunctions>();
            calcObj.RegisterType<ICalcDatabase, CalcDatabase>();
            calcObj.RegisterType<ICalcFunctions, scienceCalcFunctions>();
            
            return calcObj.Resolve<ICalc>();
            
        }
    }
}
