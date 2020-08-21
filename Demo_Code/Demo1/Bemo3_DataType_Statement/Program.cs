using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Demo3_DataType_Statement
{
    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Customer()
        {
           }
        public Customer(string name, int id, string phone, string address)
        {
            Name = name;
            Id = id;
            Phone = phone;
            Address = address;
        }
           public override string ToString()
        {
            return (Name + " " + Id + " " + Phone + " " + Address);
        }
        public override bool Equals(object o)
        {
            Customer obj = (Customer)o;
            if (this.Id == obj.Id && this.Name == obj.Name && this.Phone == obj.Phone && this.Address == obj.Address)
                return true;

            else return false;
        }

    }

    class Program
        {
            struct Employee
            {
                public int id;
                public string name;
                public string dept;
               public Employee(int eId,string eName,string eDept)
                  {
                id = eId;
                name = eName;
                dept = eDept;
                 }
            public override string ToString()
            {
                return id + " \t" + name + "\t " + dept;
            }
        };
            static void Main(string[] args)
            {
                Console.WriteLine("Hello...welcome to C#");
            //Value type data types
           // DataTypes();

            //dynamic and var data type
           // DynamicType();
            //user defined data type structure also value type
            //StructureDemo();
            //class demo
           //ClassDemo();
            //Data input conversions
          // DataInput();
            //Type casting
          // TypeCast();
            //Boxing
            //Boxing();
            //Basic operator
           BasicOperator();
            
                        }
        static void DataTypes()
        {
            int num;
            num = 5;
            Console.WriteLine(" Num is {0} size of int is {1}", num, sizeof(int));
            WriteLine($" Num is {num} size of int is {sizeof(int)}");
            char ch = 'a';
            Console.WriteLine(ch + 1);
            string name = "CSharp";
            WriteLine($"{name}");
            decimal d = 12;
            WriteLine(d);
            d = 12.67896565M;
            WriteLine(d);
            d = 23.8m;
            float f = 23.6f;
            WriteLine(f);
            
            int? a = null;//nullable type
            int? res = (a == null) ? 0 : a;

            Console.WriteLine(res);
        }
        static void DynamicType()
        {
            var v2 = "C#";//var datatype assignment compulsory
                          //v2 = 10;//Not possible as it takes the data type of initialized value
            dynamic d1;//can hold dynamic(different) datatype
            d1 = 10;
            Console.WriteLine(d1 + "\t" + v2);
            d1 = "hello";
            Console.WriteLine(d1);
            object obj = 10;///all datatype inherit from object
            WriteLine($"value of obj is {obj} and type is {obj.GetType()} ");
        }
        static void StructureDemo()
        {
            Employee emp1;
            emp1.id = 10;
            emp1.name = "Jai";
            emp1.dept = "DotNet";
            Console.WriteLine(emp1);
            Employee emp2 = emp1;
            emp1.id = 100;
            WriteLine(emp1);///value type
            WriteLine(emp2);
        }
        static void ClassDemo()
        {
            Customer customer1 = new Customer("Raj", 100, "987654321", "WellsFargo");
            WriteLine(customer1);
            Customer customer2 = customer1;
            customer1.Id = 120;
            WriteLine(customer1);
            WriteLine(customer2);

        }
        static void DataInput()
        {
            Console.WriteLine("Enter Your Name");
            string nm = Console.ReadLine();
            Console.WriteLine(nm);
            Console.WriteLine("Enter a number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num2);
            Console.WriteLine("Enter a number");
            num2 = ToInt32(Console.ReadLine());
            Console.WriteLine(num2);
        }
        static void TypeCast()
        {
            decimal num4;
            int num2 = 100;
            float f = 3.45f;
            num4 = num2;//implicit typecasting as no data loss
            Console.WriteLine("Enter a float");
            float num3 = Convert.ToSingle(Console.ReadLine());
            num2 = (int)num3;//explicit type casting as involves data loss
            Console.WriteLine(num2 + "  " + num4);
            num4 = (decimal)Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(num4);
            decimal d = (decimal)f;
        }
        
        private static void Boxing()
        {
            int i = 234;
            object o = i;//boxing
            Console.WriteLine(o);
            object o1 = o;
            Console.WriteLine(o1);
            int j = 100;
            o = j;
            o1 = o;
            Console.WriteLine(o);
            Console.WriteLine(o1);
            int k = (int)o;//unboxing
            Console.WriteLine(k);
            k = (int)o1;
            Console.WriteLine(k);
        }
        private static void BasicOperator()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int j = ToInt32(Console.ReadLine());
            Console.WriteLine(i + j);
            Console.WriteLine(i - j);
            Console.WriteLine(i * j);
            Console.WriteLine(i / j);
            Console.WriteLine(i % j);
            Console.WriteLine(i > j);
            Console.WriteLine(i < j);
            Console.WriteLine(i >= j);
            Console.WriteLine(i == j);
            Console.WriteLine(i > j && i == j);
            Console.WriteLine(i > j || i == j);
            Console.WriteLine(!(i > j));
        }
       
        }
    }
