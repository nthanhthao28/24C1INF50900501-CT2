using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ControlFlowStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BT01();
        }

        static void BT01() //check whether a given number is even or odd
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
        }
        static void BT02() //find the largest of three numbers
        {
            Console.Write("Enter the first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number:");
            double c = Convert.ToDouble(Console.ReadLine());
            double max = Math.Max(Math.Max(a,b),c);
            Console.WriteLine("The biggest number is {0}", max);
        }
        static void BT03()
        /*to accept a coordinate point in an XY coordinate system
         *and determine in which quadrant the coordinatepoint lies*/
        {
            Console.Write("Enter the X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in the First quadrant.", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in the Second quadrant.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in the Third quadrant.", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies in the Fourth quadrant.", x, y);
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("The point ({0}, {1}) is at the Origin.", x, y);
            }
            else if (x == 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies on the Y-axis.", x, y);
            }
            else if (y == 0)
            {
                Console.WriteLine("The point ({0}, {1}) lies on the X-axis.", x, y);
            }
        }
        static void BT04() //check whether a triangle is Equilateral, Isosceles or Scalene.
        {
            Console.Write("Enter the first side: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the second side: ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the third side: ");
            float c = Convert.ToSingle(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && a == c)
                {
                    Console.WriteLine($"{a}, {b}, {c} la 3 canh cua 1 tam giac deu");
                }
                else if (a == b || a == c || b == c) 
                {
                    Console.WriteLine($"{ a}, { b}, { c} la 3 canh cua 1 tam giac can");
                }
                else if (a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a) 
                {
                    Console.WriteLine($"{a}, {b}, {c} la 3 canh cua 1 tam giac vuong");
                }
                else
                {
                    Console.WriteLine($"{a}, {b}, {c} la 3 canh cua 1 tam giac thuong");
                }
            }
            else
            { 
                Console.WriteLine($"{a}, {b}, {c} khong tao thanh 1 tam giac"); 
            }
        }
        static void BT05() //read 10 numbers and find their average and sum.
        {
            double average = 0;
            double sum = 0;
            double[] numbers = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter #{0} number: ", i + 1);
                double number = Convert.ToDouble(Console.ReadLine());
                numbers[i] = number;
                sum += number;
            }
            average = sum / 10;
            Console.WriteLine("The average is {0}",average);
            Console.WriteLine("The sum is {0}", sum);
        }
        static void BT06() //display the multiplication table of a given integer.
        {
            Console.Write("You want to know the multiplication of number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                int result = number * i; 
                Console.WriteLine("{0} * {1} = {2}", number, i, result);
            }
            
        }
        static void BT07() //display a pattern like triangles with a number. 
        {
            Console.Write("Enter the number of rows: ");
            int r = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);             
                }
                Console.WriteLine();
            }

        }
        static void BT08a()
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
               
        }
        static void BT08b()
        {
            Console.Write("Enter the number of rows: ");
            int r = Convert.ToInt32(Console.ReadLine());
            int number = 1;
            for (int i = 1;i <= r; i++)
            {
                for (int j = 1;j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                { 
                    Console.Write(number + " "); 
                    number++;
                }
                Console.WriteLine();
            }
           
        }
        static void BT09() // display the n terms of harmonic series and their sum.
        {
            Console.Write("Enter the number of term: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1;i <= n;i++)
            {
                Console.Write($"1/{i} ");
                if (i < n)
                {
                    Console.Write("+ ");
                }
                sum += 1.0 / i;
            }
            Console.WriteLine();
            Console.WriteLine($"The total is {sum}");
        }       
        static void BT10() //find the ‘perfect’ numbers within a given number range.
        {
            Console.Write("Enter the start of the range: ");
            int startnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int endnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The perfect number between {startnum} and {endnum} are: ");

            for (int num = startnum; num <= endnum; num++) 
            {
                int total = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0) 
                    {
                        total += i;  
                    }                
                }
                if ( num > 0 && total == num) 
                {
                    Console.WriteLine(num);
                }
            }
        }
        static void BT11() //determine whether a given number is prime or not.
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool value = false;

            for (int i = 2; i < (number - 1); i++)
            {
                if (number > 1 && number % i != 0)
                { 
                    value  = true; 
                    break; 
                }
            }
            if (value == true)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is NOT a prime number");
            }
        }

    }
}