using System;

namespace Interface14._02._2023HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            IOutput2 obj = new EmptyClass();
            obj.ShowEven();
            Console.WriteLine("\n");
            obj.ShowOdd();
            Console.WriteLine("\n");

            ICalc obj1 = new EmptyClass();
            obj1.Less(4);
            Console.WriteLine("\n");
            obj1.Greater(2);

            ICalc2 obj3 = new EmptyClass();
            obj3.CountDistinct();
            Console.WriteLine("\n");
            obj3.EqualToValue(3);


        }
    }
}
