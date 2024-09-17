using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BT_Array
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            BT08();
            
            Console.ReadKey();  
        }
        static int[] randomNumber()
        {
            Random rnd = new Random();
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            return array;
        }
        static void BT01() //  to find the maximum of three numbers
        {
            int[] array = randomNumber();
            int x = maximum(array);
            Console.WriteLine($"The maximum value is: {x}");            
        }
        static int maximum(params int[] args)
        {
            int maxvalue = args[0];

            foreach (int i in args)
            {
                if (i > maxvalue)
                {
                    maxvalue = i;
                }
            }
            return maxvalue;
        }
        static void BT02() // To sum all the numbers in a list
        {
            int[] array = randomNumber(); 
            int sum = total(array); 
            Console.WriteLine($"The total of these numbers is: {sum}");
        }
        static int total(params int[] args) 
        {
            int sum = 0; 

            foreach (int i in args) 
            {
                sum += i; 
            }
            return sum; 
        }
        static void BT03 () // to reverse a string.
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversedString = reverse(input);
            Console.WriteLine($"A string after reversing: {reversedString} ");
        }
        static string reverse (string str) 
        {
            char[] chars = str.ToCharArray();
            string newstr = "";

            for (int i = chars.Length - 1; i >= 0; i--) 
            {
                newstr += chars[i];
            }
            return newstr;
        }
        static void BT04 () //  to calculate the factorial of a number
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32 (Console.ReadLine());
            long fac = factorial (number);
            Console.WriteLine($"The factorial of {number} is: {fac}");
        }
        static long factorial(int number)
        {
            long f = 1;
            for (int i = 1; i <= number; i++)
            {
                f *= i;
            }
            return f;
        }
        static void BT05() // to check whether the number is prime or not.
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string value = isPrime(number);
            Console.WriteLine($"The number {number} {value} a prime number.");
        }
        static string isPrime (int number) 
        {
            string val = "is";
            for (int i = 2; i < number; i++) 
            { 
                if (number % i == 0)
                {
                    val = "is not";
                }
            }
            return val;
        }
        static void BT06() // To find prime numbers less than a given number & the first N prime numbers
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Prime numbers less than {number}: ");
            int[] primes = primeLessThan(number);
            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"The first prime number: {primes[0]}");
        }
        static int[] primeLessThan(int number)
        {
            int[] primes = new int[number];
            int count = 0;

            for (int i = 2; i < number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes[count] = i;
                    count++;
                }
            }           
            Array.Resize(ref primes, count);

            return primes;
        }
        static void BT07() // to check whether a number is "Perfect" or not & print all perfect number that less than 1000.
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = isPerfect(number);
            Console.WriteLine($"The number {number} {str} a perfect number");
            int[] perfectnum = perfectNumberLessThan(number);
            Console.Write($"The perfect number less than {number}: ");
            foreach (var nu in perfectnum)
            { 
                Console.Write(nu + " "); 
            } 
            Console.WriteLine();
        }
        static string isPerfect(int number) 
        {
            int sum = 0;
            for (int i = 1; i <= number/2; i++) 
            { 
                if (number % i == 0)
                {  
                    sum += i; 
                }
            }
            if (sum == number)
            {
                return "is";
            }
            else 
            {
                return "is not";
            }
        }
        static int[] perfectNumberLessThan (int number) 
        {
            int[] perfectnumbers = new int[number];
            int count = 0;  
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0) 
                    { 
                        sum += j;
                    }
                }
                if (sum == i) 
                { 
                    perfectnumbers[count] = i;
                    count++;
                }
            }
            Array.Resize(ref perfectnumbers, count);

            return perfectnumbers;
        }
        static void BT08 () // to check whether a string is a pangram or not.
        {
            Console.Write("Enter a string: ");
            string a = Console.ReadLine();
            string val = isPangram(a);
            Console.WriteLine($"This sentence {val} a pangram");
        }
        static string isPangram(string str) 
        {
            str = str.ToLower();
            for (char letter = 'a'; letter <= 'z'; letter++)
            {                
                if (!str.Contains(letter))
                {
                    return "is not";
                }
            }           
            return "is";      
        }
    } 
}