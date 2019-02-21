using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFuctionLibrary
{
    public class Circle
    {
        public double Radius { get; set; }

        public double Circumference(double radius)
        {
            Radius = radius;
            double circumference;

            if (radius < 0)
            {
                Console.WriteLine(" Please enter a positive number");
            }

            circumference = 2 * Math.PI * radius;

            return circumference;
        }

        public double CircleArea(double radius)
        {
            Radius = radius;
            double Area = Math.PI * radius * radius;

            return Area;
        }
    }
}

    

