/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// A 'SimpleInterest' class
/// </summary>
namespace RetryFactoryClass
{
    class SimpleInterest : IfactoryInterest
    {
        double amount;
        double years;
        double roi;
        
        public SimpleInterest(Dictionary<string, double> SiDictionary)
        {
            this.amount = SiDictionary["amount"];
            this.years = SiDictionary["years"];
            this.roi = SiDictionary["rateOfIntrest"];

        }
        public double Interest()
        {
            double result = 0;
            result = amount * roi * years;
            return result;
        }
    }
}
