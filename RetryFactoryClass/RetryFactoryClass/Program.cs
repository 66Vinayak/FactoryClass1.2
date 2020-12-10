using System;

namespace RetryFactoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Factory Class----");
            Console.WriteLine("----Choose which Intrest to Calculate----");
            Console.WriteLine("i)SimpleIntrest-->1");
            Console.WriteLine("ii)CompoundIntrest-->2");
            var selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                int years;
                float rateOfIntrest;
                double amount;

                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                rateOfIntrest = float.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                var siObject = FactoryClass.GetIntrest(amount, years, rateOfIntrest);
                var siResult = siObject.Interest();
                Console.Write("Simple Intrest is " + siResult);
            }
            else if (selection == 2)
            {
                int years;
                int annualCompound;

                float rateOfIntrest;
                double amount;

                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                rateOfIntrest = float.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                Console.Write("Compounding frequency quarterly or monthly : ");
                annualCompound = int.Parse(Console.ReadLine());

                var CiObject = FactoryClass.GetIntrest(amount, years, rateOfIntrest, annualCompound);
            var ciResult = CiObject.Interest();
                Console.Write("After " + years + " years there will be a " + ciResult + " in the Account");

            }
            Console.ReadKey();
        }
    }
}
