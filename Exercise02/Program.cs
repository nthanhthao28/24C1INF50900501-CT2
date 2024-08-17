using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("After swapping values of two variables:");

            double total = num1 + num2;
            double Num1 = total - num1;
            double Num2 = total - Num1;
            Console.WriteLine($"The first number is {Num1}");
            Console.WriteLine($"The second number is {Num2}");
           
            Console.ReadKey();
        }
    }
}
