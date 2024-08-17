using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the second number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            decimal product = num1 * num2;
            Console.WriteLine($"The product is {product}");
            Console.ReadKey();
        }
    }
}
