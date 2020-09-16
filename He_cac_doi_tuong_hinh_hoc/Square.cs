using System;
using System.Collections.Generic;
using System.Text;

namespace He_cac_doi_tuong_hinh_hoc
{
    class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, String Color, bool Filled) : base(side, side, Color, Filled)
        {

        }

        public double GetSide()
        {
            return GetWidth();
        }

        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }
        public override void SetWidth(double width)
        {
            SetSide(width);
        }
        public override void SetLength(double length)
        {
            SetSide(length);
        }
        public override string ToString()
        {
            return "A Square with side = " + GetSide() + ", which is a subclass of " + base.ToString();
        }
    }
}
