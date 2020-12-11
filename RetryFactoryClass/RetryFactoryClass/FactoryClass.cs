/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace RetryFactoryClass
{
   public static class FactoryClass
    {
        public static IfactoryInterest GetIntrest(Dictionary<string,double> valuee, InterstType choose)
        {
            switch (choose)
            {
                case InterstType.SimpleIntrest:
                    return new SimpleInterest(valuee);
                case InterstType.CompoundIntrest:
                    return new CompoundInterest(valuee);
                default:
                    throw new ApplicationException(string.Format(" Object Intrest cannot be created"));
            }
        }
    }
}
