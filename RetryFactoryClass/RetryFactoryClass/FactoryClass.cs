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
        public static IfactoryInterest GetIntrest(Dictionary<string,double> valuee,int choose)
        {
            switch (choose)
            {
                case 0:
                    return new SimpleInterest(valuee["amount"], valuee["years"], valuee["rateOfIntrest"]);
                case 1:
                    return new CompoundInterest(valuee["amount"], valuee["years"], valuee["rateOfIntrest"], valuee["annualCompound"]);
                default:
                    throw new ApplicationException(string.Format(" Object Intrest cannot be created"));
            }
        }
    }
}
