using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_CS
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int h, int w)
        {
            height = h;
            width = w;
        }

        override public double Area()
        {
            return width * height;
        }
    }
}
