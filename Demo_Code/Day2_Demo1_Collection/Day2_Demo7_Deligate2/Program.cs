using System;
using static System.Console;
namespace Day2_Demo7_Deligate2
{
    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //method reference directly
            // calAreaPointer cptr = new calAreaPointer(calArea);
            // WriteLine(cptr(20));
            //anonymous method
            //calAreaPointer cptr = new calAreaPointer(delegate (double r)
            //{

            //    return 3.14 * r * r;
            //});
            //WriteLine(cptr(12));
            //above code you can simplify with lambda
            // calAreaPointer cptr= (r => 3.14 * r * r);
            //WriteLine(cptr(12));
           // prebuild delegates Func<>,Action<>,Predicate<>
            //Func delegate can have input and out parameter
            Func<double, double> f1 = (r => 3.14 * r * r);
            WriteLine(f1(10));
        }
        public static double calArea(double r)
        {

            return 3.14 * r * r;
        }
    }
}
