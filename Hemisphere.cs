using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFuctionLibrary
{
    public class Hemisphere
    {
        public double Radius { get; set; }

        public double HemisphereVolume(double radius)
        {
            Radius = radius;
            double Volume;

            if (radius < 0)
            {
                Console.WriteLine(" Please enter a positive number");
            }

            Volume = ((4.0 / 3) * Math.PI * Math.Sqrt(radius) * radius) / 2;

            return Volume;
        }
    }
}
