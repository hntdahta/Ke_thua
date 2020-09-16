using System;

namespace Circle_va_Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.SetColor("White");
            circle.SetRadius(4.3);
            Console.WriteLine(circle.ToString());
            Console.WriteLine("----------------\n");

            Cylinder cylinder = new Cylinder(7.6,"Black",4.5);
            Console.WriteLine(cylinder.ToString());
        }
    }
}
