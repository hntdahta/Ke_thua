using System;
using System.Collections.Generic;
using System.Text;

namespace Point_va_MovablePoint
{
    class MovablePoint : Point
    {
        public float xSpeed = 0.0f;
        public float ySpeed = 0.0f;
        public MovablePoint()
        {

        }

        public MovablePoint(float x, float y, float xSpeed, float ySpeed) : base(x, y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public float GetxSpeed()
        {
            return xSpeed;
        }

        public void SetxSpeed(float xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public float GetySpeed()
        {
            return ySpeed;
        }

        public void SetySpeed(float ySpeed)
        {
            this.ySpeed = ySpeed;
        }
        
        public float[] GetSpeed()
        {
            return new float[2] {xSpeed,ySpeed};
        }

        public void SetSpeed(float xSpeed, float ySpeed)
        {

            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public MovablePoint Move()
        {
            x += xSpeed;
            y += ySpeed;
            //SetX(GetX() + GetxSpeed());
            //SetY(GetY() + GetySpeed());
            return this;
        }
        public override string ToString()
        {
            return "x = " + GetX() + ", y = " + GetY() + ", xSpeed = " + GetxSpeed() + ", ySpeed = " + GetySpeed();
        }
    }
}
