using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_CS
{
    class Circle : Shape
    {
        int radius;
        readonly static double PI = 3.1417;

        public Circle (int r)
        {
            radius = r;
        }

        public override double Area()
        {
            return 0;
            // TODO: Calculate Area of circle
            // PI is defined
            return PI * (radius^2);
        }
    }
}
