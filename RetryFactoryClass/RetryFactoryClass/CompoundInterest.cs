/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// A 'CompoundIneterest' class
/// </summary>
namespace RetryFactoryClass
{
    class CompoundInterest : IfactoryInterest
    {
        double amount;
        double years;
        double roi;
        double annualCompound;
        public CompoundInterest(Dictionary<string, double> CiDictionary)
            {
            this.amount = CiDictionary["amount"];
            this.years = CiDictionary["years"];
            this.roi = CiDictionary["rateOfIntrest"];
            this.annualCompound = CiDictionary["annualCompound"];
        }
        public double Interest()
        {
            double result = 0;
            result = amount * Math.Pow((1 + (roi / annualCompound)), (annualCompound * years));

            return result;
        }
    }
}
