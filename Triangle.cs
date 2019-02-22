using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFuctionLibrary
{
    public class Triangle
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public double HeronFormula(int a, int b, int c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

            if ((a <= 0) && (b <= 0) && (c <= 0))
            {
                Console.WriteLine(" Please enter a positive number greater than 1");
            }

            double HalfCircumference;
            double Area;

            HalfCircumference = (a + b + c) / 2;

            Area = Math.Sqrt(HalfCircumference * (HalfCircumference - a) * (HalfCircumference - b) * (HalfCircumference - c));

            return Area;

        }
    }
}
