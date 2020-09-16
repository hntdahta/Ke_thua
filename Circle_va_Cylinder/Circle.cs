using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_va_Cylinder
{
    class Circle
    {
        public double radius;
        public string color;

        public Circle()
        {

        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override String ToString()
        {
            return "Color = " + GetColor() + ", Radius = " + GetRadius() + ", Area = " + GetArea();
        }
    }
}
