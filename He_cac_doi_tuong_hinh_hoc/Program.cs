using System;

namespace He_cac_doi_tuong_hinh_hoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape");
            Shape shape = new Shape();
            Console.WriteLine(shape);
            shape = new Shape("black", false);
            Console.WriteLine(shape);
            Console.WriteLine("--------------\n");
            
            Console.WriteLine("Cricle");
            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(4.3);
            Console.WriteLine(circle);
            Console.WriteLine(circle.GetPerimeter());
            Console.WriteLine(circle.GetArea());
            circle = new Circle(3.6, "Yellow", false);
            Console.WriteLine(circle);
            Console.WriteLine(circle.GetPerimeter());
            Console.WriteLine(circle.GetArea());
            Console.WriteLine("--------------\n");

            Console.WriteLine("Rectangle");
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(2.3, 4.8);
            Console.WriteLine(rectangle);
            Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine(rectangle.GetArea());
            rectangle = new Rectangle(3.5,7.6, "Brown", false);
            Console.WriteLine(rectangle);
            Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine("--------------\n");

            Console.WriteLine("Square");
            Square square = new Square(3.5);
            Console.WriteLine(square);
            Console.WriteLine(square.GetPerimeter());
            Console.WriteLine(square.GetArea());
            square = new Square(5, "White", false);
            Console.WriteLine(square);
            Console.WriteLine(square.GetPerimeter());
            Console.WriteLine(square.GetArea());
        }
    }
}
