using System;
using System.Collections.Generic;
using System.Text;

namespace RetryFactoryClass
{
   public static class FactoryClass
    {
        public static IfactoryInterest GetIntrest(double amount, int years, float roi, int annualCompound = 0)
        {
            if(annualCompound==0)
            {
                return new SimpleInterest(amount,years,roi);
            }
            else
            return new CompoundInterest(amount,years,roi,annualCompound);
                 
        }
    }
}
