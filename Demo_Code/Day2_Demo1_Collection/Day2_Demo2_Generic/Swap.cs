using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Demo2_Generic
{
    class swapData
    {
        int value1;
        int value2;
        public void swapValues(int i, int j)
        {
            int temp;

            value1 = i;
            value2 = j;
            temp = value1;
            value1 = value2;
            value2 = temp;
            Console.WriteLine(this.value1.ToString());
            Console.WriteLine(this.value2.ToString());

        }
    }

    class swap<T> //where T:Customer
    {
        T value1;
        T value2;
        public void swapValues(T i, T j)
        {
            T temp;

            value1 = i;
            value2 = j;
            temp = value1;
            value1 = value2;
            value2 = temp;
            Console.WriteLine(this.value1.ToString());
            Console.WriteLine(this.value2.ToString());

        }

    }

}
