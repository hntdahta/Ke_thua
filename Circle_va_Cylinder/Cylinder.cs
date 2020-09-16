using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_va_Cylinder
{
    class Cylinder : Circle
    {
        public double height;
        public Cylinder()
        {

        }
        public Cylinder(double height, string color, double radius) : base (radius,color)
        {
            this.height = height;
        }

        public Cylinder(double height)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetTotalArea()
        {
            return base.GetArea() * this.height;
        }
        public override string ToString()
        {
            return "Height = " + GetHeight() + ", Total Area = " + GetTotalArea() + ", " + base.ToString();
        }
    }
}
