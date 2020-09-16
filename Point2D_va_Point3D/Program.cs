using System;

namespace Point2D_va_Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Point 2D");
            Point2D point2D = new Point2D();
            Console.WriteLine(point2D);
            point2D = new Point2D(1.6f, 2.9f);
            Console.WriteLine(point2D);
            Console.WriteLine(point2D.ToString());
            Console.WriteLine("--------------\n");

            Console.WriteLine("Point 3D");
            Point3D point3D = new Point3D();
            Console.WriteLine(point3D);
            point3D = new Point3D(1.5f, 2.5f,3.4f);
            Console.WriteLine(point3D);
            Console.WriteLine(point3D.ToString());
        }
    }
}
