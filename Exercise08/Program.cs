using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.Write("Enter the radius in cm: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double S = pi * r;
            Console.WriteLine($"The area is {S}" + "cm");
            Console.ReadKey();
        }
    }
}
