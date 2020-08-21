

using System;
namespace DemoNamespace1
{
    class Class1
    {
        public void Display()
        {
            Console.WriteLine("Class1");
        }
    }
}
namespace DemoNamespace2
{
    class Class1
    {
        public void Display()
        {
            Console.WriteLine("Class2");
        }
    }
}

namespace Demo2_namespace
{


    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new DemoNamespace1.Class1();
            var obj2 = new DemoNamespace2.Class1();
            obj1.Display();
            obj2.Display();

        }
    }
}
