using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The type of data is: ");
            string type = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    Console.WriteLine("The size of this type is: " + sizeof(int) + " bytes");
                    break;
                case "long":
                    Console.WriteLine("The size of this type is: " + sizeof(long) + " bytes");
                    break;
                case "short":
                    Console.WriteLine("The size of this type is: " + sizeof(short) + " bytes");
                    break;
                case "float":
                    Console.WriteLine("The size of this type is: " + sizeof(float) + " bytes");
                    break;
                case "double":
                    Console.WriteLine("The size of this type is:  " + sizeof(double) + " bytes");
                    break;
                case "bool":
                    Console.WriteLine("The size of this type is:  " + sizeof(bool) + " byte");
                    break;
                case "char":
                    Console.WriteLine("The size of this type is:  " + sizeof(char) + " bytes");
                    break;              
            }
            
            Console.ReadKey();

        }
    }
}
