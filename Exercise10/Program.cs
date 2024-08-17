using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int y = n / 365;
            int w = (n - 365 * y ) / 7;
            int d = (n - 365 * y - 7 * w);

            Console.WriteLine($"{n} days = {y} years, {w} weeks, and {d} days ");
            Console.ReadKey();
        }
    }
}
