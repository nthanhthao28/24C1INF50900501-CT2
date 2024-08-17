using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side in cm:");
            double a = Convert.ToDouble(Console.ReadLine());

            double S = a * a;
            Console.WriteLine($"The Area is {S}" +"cm^2");
            Console.ReadKey();
        }
    }
}
