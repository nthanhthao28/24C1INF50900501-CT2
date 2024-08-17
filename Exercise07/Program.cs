using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any character: ");
            char c = Convert.ToChar(Console.ReadLine());
            int asciivalue = (int)c;

            Console.WriteLine($"ASCII value of {c} is: {asciivalue}");
            Console.ReadKey();
        }
    }
}
