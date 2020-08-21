using System;
using static System.Console;
namespace Demo1_BasicOops
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCalc.Calculator myCalculator = new DemoCalc.Calculator();//constructor
            WriteLine(myCalculator);
            Console.WriteLine(myCalculator.name);//readonly property
            myCalculator.Type = "digital";//public property
            WriteLine(myCalculator);
            myCalculator.Add(10, 20);
            myCalculator.Multiply(30, 40);
            DemoCalc. Calculator myCalculator2 = new DemoCalc.Calculator("Sony","digital");//parameter constructor

            WriteLine(myCalculator2);

            myCalculator.Add(10, 20);
            myCalculator.Multiply(30, 40);
        }
    }
}
