using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int total = num1 + num2;
            Console.WriteLine("The total is {0}", total);
            Console.ReadKey();
        }
    }
}
