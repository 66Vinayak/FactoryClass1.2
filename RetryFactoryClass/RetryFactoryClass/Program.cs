/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;

namespace RetryFactoryClass
{
    
    class Program
    {
        enum InterstType
    {
        SimpleIntrest,
        CompoundIntrest

    }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----Factory Class----");
                Console.WriteLine("----Choose which Intrest to Calculate----");
                Console.WriteLine("i)SimpleIntrest-->1");
                Console.WriteLine("ii)CompoundIntrest-->2");
                var selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    double years;
                    double rateOfIntrest;
                    double amount;

                    Console.WriteLine("Enter principal Amount:");
                    amount = double.Parse(Console.ReadLine());

                    Console.Write("Enter the rate of interest : ");
                    rateOfIntrest = double.Parse(Console.ReadLine()) / 100;

                    Console.Write("Enter the total number of years : ");
                    years = double.Parse(Console.ReadLine());
                    Dictionary<string, double> Valuespair = new Dictionary<string, double>();
                    Valuespair.Add("amount", amount);
                    Valuespair.Add("years", years);
                    Valuespair.Add("rateOfIntrest", rateOfIntrest);
                    var siObject = FactoryClass.GetIntrest(Valuespair, (int)InterstType.SimpleIntrest);
                    var siResult = siObject.Interest();
                    Console.Write("Simple Intrest is " + siResult);
                }
                else if (selection == 2)
                {
                    double years;
                    double annualCompound;

                    double rateOfIntrest;
                    double amount;

                    Console.WriteLine("Enter principal Amount:");
                    amount = double.Parse(Console.ReadLine());

                    Console.Write("Enter the rate of interest : ");
                    rateOfIntrest = double.Parse(Console.ReadLine()) / 100;

                    Console.Write("Enter the total number of years : ");
                    years = double.Parse(Console.ReadLine());

                    Console.Write("Compounding frequency quarterly or monthly : ");
                    annualCompound = double.Parse(Console.ReadLine());
                    Dictionary<string, double> Valuespair = new Dictionary<string, double>();
                    Valuespair.Add("amount", amount);
                    Valuespair.Add("years", years);
                    Valuespair.Add("rateOfIntrest", rateOfIntrest);
                    Valuespair.Add("annualCompound", annualCompound);
                    var CiObject = FactoryClass.GetIntrest(Valuespair, (int)InterstType.CompoundIntrest);
                    var ciResult = CiObject.Interest();
                    Console.Write("After " + years + " years there will be a " + ciResult + " in the Account");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("----error----" + ex);
            }
            Console.ReadKey();
        }
    }
}
