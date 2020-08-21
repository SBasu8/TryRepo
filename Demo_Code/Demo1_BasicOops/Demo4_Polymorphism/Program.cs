using System;

namespace Demo4_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape picture = new Shape("Shapes");
            picture.Draw();
            picture.Draw(5);
            picture.Draw(3, 4, "Red");
            picture.Draw(6, "Blue", 8);
        }
    }
}
