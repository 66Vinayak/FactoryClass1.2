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
        
        public SimpleInterest(double amount, double years, double roi)
        {
            this.amount = amount;
            this.years = years;
            this.roi = roi;
           
        }
        public double Interest()
        {
            double result = 0;
            result = amount * roi * years;
            return result;
        }
    }
}
