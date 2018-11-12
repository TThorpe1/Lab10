using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;

        public double Radius

        {
            get { return radius; }
        }
        public Circle(double newRadius)

        {
            radius = newRadius;
        }

        private string FormatNumber(double x)

        {
            double roundedAnswer = Math.Round(x, 2);
            
            return roundedAnswer.ToString();
        }

        public double CalculatedCircumference()

        {
            return 2 * Math.PI * radius;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculatedCircumference());
        }

        public double CalculateArea()

        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public string CalculateFormattedArea()

        {
            return FormatNumber(CalculateArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");

            bool loop = true;
            int circleCount = 0;
            while (loop)
            {
                double radius;
                Console.Write("Enter radius: ");
                if (double.TryParse(Console.ReadLine(), out radius))
                {
                   
                    circleCount++;

                    Circle circle = new Circle(radius);
                    Console.WriteLine("Circumference: " + circle.CalculateFormattedCircumference());
                    Console.WriteLine("Area: " + circle.CalculateFormattedArea());
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.Write("Continue? (y/n) ");

                if (Console.ReadLine() == "n")
                {
                    loop = false;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Goodbye. You created " + circleCount + "  Circle object(s)");
        }
    }
}
