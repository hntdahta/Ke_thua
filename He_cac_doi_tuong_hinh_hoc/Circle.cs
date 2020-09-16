using System;
using System.Collections.Generic;
using System.Text;

namespace He_cac_doi_tuong_hinh_hoc
{
    class Circle : Shape
    {
        public double radius = 1.0;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string Color, bool Filled) : base(Color,Filled)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {
            return "A Circle with radius = " + GetRadius() + ", which is a subclass of " + base.ToString();
        }
    }
}
