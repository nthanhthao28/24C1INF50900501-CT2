using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal a = 9 / 5m;
            Console.WriteLine("You want to convert:");
            Console.WriteLine("Celsius to Fahrenheit: press 1");
            Console.WriteLine("Fahrenheit to Celsius: press 2");    
            int nu = Convert.ToInt32(Console.ReadLine());

            if (nu == 1)
            {
                Console.Write("Celsius = ");
                decimal cel = Convert.ToDecimal(Console.ReadLine());

                decimal fah = (cel * a) + 32;
                Console.WriteLine($"Fahrenheit = {fah}");
                Console.ReadKey();
            }
            else if (nu == 2)
            {
                Console.Write("Fahrenheit = ");
                decimal fah = Convert.ToDecimal(Console.ReadLine());

                decimal cel = (fah - 32) * 1 / a;
                Console.WriteLine($"Celsius = {cel}");
                Console.ReadKey();
            }
        }
    }
}
