using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFuctionLibrary
{
    public class Quadratic
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double QuadraticX1(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            double x1;


            if ((a < 0) && (b < 0) && (c < 0))
            {
                Console.WriteLine(" Please enter a positive number");
            }

            x1 = ((-b) + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);

            return x1;

        }

        public double QuadraticX2(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            double x2;


            if ((a < 0) && (b < 0) && (c < 0))
            {
                Console.WriteLine(" Please enter a positive number");
            }

            x2 = ((-b) - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);

            return x2;

        }
    }
}
