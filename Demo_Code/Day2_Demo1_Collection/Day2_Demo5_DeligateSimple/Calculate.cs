using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Demo5_DeligateSimple
{
    class Calculate
    {
        public  double calArea(double r)
        {
            Console.WriteLine("calsarea");
            return 3.14 * r * r;
        }
        public  double caldistance(double d)
        {
            return d * 100;
        }
    }
}

