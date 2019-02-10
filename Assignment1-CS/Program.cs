using System;

namespace Assignment1_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(10, 5);
            Console.WriteLine("myRectangle's area is: " + myRectangle.Area().ToString());

            Circle myCircle = new Circle(10);
            Console.WriteLine("myCircle's area is: " + myCircle.Area().ToString());
            Console.ReadKey();
        }
    }
}
