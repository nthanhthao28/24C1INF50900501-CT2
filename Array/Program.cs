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
            Random rnd = new Random();
            int[] m = new int[20];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = rnd.Next(0, 50);
                Console.Write(m[i] + "  ");
            }
            Console.WriteLine();
            BT08(m);
            Console.ReadKey();
        }
        static void BT01(int[] m) // to calculate the average value of array elements.
        {
            int sum = 0;
            for (int i = 0; i < m.Length; i++)
            {
                sum += m[i];
            }
            double avg = (double)sum / m.Length;
            Console.WriteLine($"The average value is: {avg}");
        }
        static void BT02(int[] m) // to test if an array contains a specific value.
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int dem = 0;

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == number)
                {
                    dem++;
                }
            }
            if (dem > 0)
            {
                Console.WriteLine($"The number {number} appear {dem} time(s) in the array");
            }
            else
            {
                Console.WriteLine($"The number {number} does not appear in the array");
            }
        }
        static void BT03(int[] m) // To find and print all indices of an array element
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == number)
                {
                    if (!found)
                    {
                        Console.Write($"The number {number} is found at indices: ");
                        found = true;
                    }
                    Console.Write(i + " ");
                }
            }

            if (!found)
            {
                Console.WriteLine($"The number {number} was not found in the array.");
            }
            else
            {
                Console.WriteLine();
            }
        }
        static int[] BT04(int[] m) // to remove a specific element from an array.
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < m.Length; i++) 
            {
                if (m[i] == number) 
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"The number {number} was not found in the array");
                return m;
            }
            else
            {
                int[] newArray = new int[m.Length - count];
                int newIndex = 0;

                for (int i = 0; i < m.Length; i++)
                {
                    if (m[i] != number)
                    {
                        newArray[newIndex] = m[i];
                        newIndex++;
                    }
                }
                Console.WriteLine("Array after removing the number: ");
                for (int i = 0;i < newArray.Length; i++) 
                {
                    Console.Write(newArray[i] + "  ");
                }
                return newArray;
            }
        }
        static void BT05(int[] m) //  to find the maximum and minimum value of an array.
        {
            int min = m[0], max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] > min)    
                { 
                    min = m[i];
                }
                if (m[i] < max)
                {
                    max = m[i];
                }              
            }
            Console.WriteLine($"The maximum is: {max}");
            Console.WriteLine($"The minimum is: {min}");
        }
        static void BT06(int[] m) //  to reverse an array of integer values.
        {
            Console.Write($"The array after reversing: ");
            for (int i = m.Length - 1; i >= 0; i--) 
            {
                Console.Write(m[i] + " ");
            }
        }
        static void BT07(int[] m) // to find duplicate values in an array of values.
        {
            Console.Write("The numbers that duplicate in this array: ");
            bool[] printed = new bool[m.Length];

            for (int i = 0; i < m.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < m.Length; j++)
                {
                    if (m[i] == m[j]) 
                    { 
                        count ++;
                    }
                }
                if (count > 1 && !printed[i])
                {
                    Console.Write(m[i] + " ");

                    for (int k = 0;k < m.Length; k++) 
                    { 
                        if (m[i] == m[k]) 
                        {
                            printed[k] = true;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
        static void BT08(int[] m) //  to remove duplicate elements from an array.
        { 
            int newSize = m.Length;
            for (int i = 0; i < newSize; i++)
            {               
                for (int j = i + 1; j < newSize; j++)
                {
                    if (m[i] == m[j]) 
                    { 
                        for (int k = j; k < newSize - 1; k++)
                        {
                            m[k] = m[k + 1];
                        }
                        newSize--;
                        j--;
                    }
                }                                                  
            }  
            int[] newArray = new int[newSize];
            for (int i = 0; i < newSize;i++) 
            { 
                newArray[i] = m[i];
            }
            Console.WriteLine("The array after removing the duplicate value: ");
            for (int i = 0;i < newSize;i++)
            {
                Console.Write(newArray[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}