using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            double square;

            Console.WriteLine("Please, enter the radius of the circle.");

            radius = Convert.ToDouble(Console.ReadLine());
            square = pi * (radius * radius);

            Console.WriteLine(square);
        }

    }
}