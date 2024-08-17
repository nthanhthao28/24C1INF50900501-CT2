using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal f = 0.3048m;
            Console.Write("Feet = ");
            decimal feet = Convert.ToDecimal(Console.ReadLine());

            decimal meter = feet * f;
            Console.WriteLine($"Meter = {meter}");
            Console.ReadKey();
        }
    }
}
