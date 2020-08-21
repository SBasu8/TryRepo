using System;

namespace Day2_Demo2_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            swapData data = new swapData();
            data.swapValues(100, 200);
            swap<int> sdata = new swap<int>();
            sdata.swapValues(10, 20);
            swap<float> sdata1 = new swap<float>();
            sdata1.swapValues(12.8f, 34.7f);
            swap<string> sdata2 = new swap<string>();
            sdata2.swapValues("Hello", "welcome");
            swap<Customer> sdata3 = new swap<Customer>();
            sdata3.swapValues(new Customer("Ram", 25, "9876543", "Amazon"), new Customer("Radha", 50, "9876543789", "Amazon"));

        }
    }
}
