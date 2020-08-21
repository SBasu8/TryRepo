using System;

namespace DemoInterface
{
    interface IInfo
    {
        string Name { get; set; }
        int Age { get; set; }

        void showInfo();

    }
    class Passenger : IInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mode { get; set; }
        public Passenger(string name, int age,string mode)
        {
            this.Name = name;
            this.Age = age;
            this.Mode = mode;
        }
        public void showInfo()
        {
            Console.WriteLine("The passenger details\n Name: " + this.Name + "\n Age: " + this.Mode + "\n Mode of transport: " + this.Mode);
        }

    }
    class Traveller : IInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Destination { get; set; }
        public Traveller(string name, int age,string destination)
        {
            this.Name = name;
            this.Age = age;
            this.Destination = destination;
        }
        public void showInfo()
        {
            Console.WriteLine("The Traveller details\n Name: " + this.Name + "\n Age: " + this.Age + "\n Destination: " + this.Destination);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Information System");
            Console.WriteLine("1.Traveller\n2.Passenger");
            IInfo info = null;
            Console.WriteLine("Enter your Choice");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Enter your destination");
                    string destination = Console.ReadLine();
                    info = new Traveller(name, age,destination);
                    info.showInfo();
                    break;
                case 2:
                    Console.WriteLine("Enter your Mode of transport");
                    string mode = Console.ReadLine();
                    
                    info = new Passenger(name, age, mode);
                    info.showInfo();
                    break;
                case 3: Console.WriteLine("Sorry wrong choice"); break;
            }

            Console.ReadLine();
        }

    }
}
