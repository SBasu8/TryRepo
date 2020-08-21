using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace DemoCalc
{
    class Calculator
    {
       internal string name;//member variable
        //internal string Name//Read only property
        //{
        //    get
        //    {
        //        return name;
        //    }

        //}
        private string make;
        // public string Make { get => make; set => make = value; }

        public string Type//auto implemented property
        {
            get;
            set;
        }
        public string Make { get => make; set => make = value; }

        public Calculator()//constructor
        {
            name = "Casio 100Fx";
            Make = "Casio";
            Type = "Scientific";
        }
        public Calculator(string make, string type)//Constructor with parameter
        {
            name = "Sony 200x";
            Make = make;
            Type = type;
        }
        public override string ToString()
        {
            return $"{name}  {Make}  {Type}";
        }
        public void Add(int num1, int num2)
        {

            Console.WriteLine(num1 + num2);
        }
        void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
