using System;
using System.Collections.Generic;

namespace OCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaCalculator = new AreaCalculator();
            var shapes = new List<IShape>()
            { 
                new Rectangle {Width = 40, Height = 20},
                new Circle {Radius = 10}
            };


            Console.WriteLine("OCP - Open Closed Principle\n");
            Console.WriteLine("Una clase debe estar abierta para extensiones pero cerrada para modificaciones\n");

            Console.WriteLine(areaCalculator.Area(shapes));
        }
    }
}
