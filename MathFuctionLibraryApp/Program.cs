using MathFuctionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFuctionLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area and circumference of circle");
            Console.WriteLine("********************************");

            Circle circle = new Circle();
            Console.Write("Enter the radius of the circle: ");
            string r = Console.ReadLine();
            double radius = double.Parse(r);
            Console.WriteLine("----------------------------------" + "\n");

            double circumference = circle.Circumference(radius);
            Console.Write("The circumference of the circle is: " + circumference.ToString("F"));
            Console.WriteLine();
            Console.WriteLine("The area of the circle is: " + circle.CircleArea(radius).ToString("F"));
            Console.ReadKey();
            Console.WriteLine("----------------------------------" + "\n");

            Console.WriteLine("Area of triangle");
            Console.WriteLine("****************");

            Triangle triangle = new Triangle();
            Console.Write("Enter the lenght of side A: ");
            string a = Console.ReadLine();
            int SideA = int.Parse(a);
            Console.Write("Enter the lenght of side B: ");
            string b = Console.ReadLine();
            int SideB = int.Parse(b);
            Console.Write("Enter the lenght of side C: ");
            string c = Console.ReadLine();
            int SideC = int.Parse(c);

            Console.WriteLine("----------------------------------" + "\n");

            Console.Write("The area of the triangle is: " + triangle.HeronFormula(SideA, SideB, SideC).ToString("F"));
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("----------------------------------" + "\n");

            Console.WriteLine("Solving a quadratic equation");
            Console.WriteLine("*****************************");

            Quadratic quadratic = new Quadratic();
            Console.Write("Enter A value: ");
            string ax = Console.ReadLine();
            int A = int.Parse(ax);
            Console.Write("Enter B value: ");
            string bx = Console.ReadLine();
            int B = int.Parse(bx);
            Console.Write("Enter C value: ");
            string cx = Console.ReadLine();
            int C = int.Parse(cx);

            Console.WriteLine("----------------------------------" + "\n");

            Console.Write("The result of the equation are: " + quadratic.QuadraticX1(A, B, C).ToString("F") + " and " + quadratic.QuadraticX2(A, B, C).ToString("F"));
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("----------------------------------" + "\n");

            Console.WriteLine("Volume of hemisphere");
            Console.WriteLine("********************");

            Hemisphere hemisphere = new Hemisphere();
            Console.Write("Enter the radius: ");
            string R = Console.ReadLine();
            double HemisphereRaduis = double.Parse(R);

            Console.WriteLine("----------------------------------" + "\n");

            Console.Write("The area of the triangle is: " + hemisphere.HemisphereVolume(HemisphereRaduis).ToString("F"));
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("----------------------------------" + "\n");


        }
    }
}
