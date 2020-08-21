using System;
using System.Collections.Generic;
using System.Text;

namespace Demo4_Polymorphism
{
    class Shape
    {
        string Name { get; set; }
        public Shape(string name)
        {
            this.Name = name;
        }
        public void Draw()
        {
            Console.WriteLine("You can draw any Shape");
        }
        public void Draw(int r)
        {
            Console.WriteLine("Circle is drawn with radious " + r);
        }
        public void Draw(int l, int w, string color)
        {
            Console.WriteLine("Rectangle is drawn with length " + l + " and width" + w);
        }
        public void Draw(int l, string color, int w)
        {
            Console.WriteLine("Rectangle is drawn with length " + l + " and width" + w);
        }
    }
}
