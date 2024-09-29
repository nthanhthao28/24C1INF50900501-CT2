using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BT_Array
{
    internal class Program
    {
        /* Create a Jagged Array with random integer numbers (or by user input) by getting the 
        number of rows and columns from the user and printing the data in the array to the user.
        Then, create functions to implement following tasks:
        1. Print the biggest number of each row and the largest number of the whole array.
        2. Sort values ascending of each row.
        3. Print items of the array that are prime.
        4. Search and print all positions of a number (enter from the user). */
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[rows][];
            init_random(a,rows);
            print(a);
            maxinrow(a);
            maxinarray(a);
            sort_row(a);
            print_prime(a);
            print_position(a);
        }
        static void init_random(int[][] a, int rows) // Create a Jagged Array with random integer numbers
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++) 
            {
                int cols = rnd.Next(2,10);
                a[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    a[i][j] = rnd.Next(10,50);
                }
            }
        }
        static void print (int[][] a) 
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0;j < a[i].Length; j++) 
                { 
                    Console.Write(a[i][j] + "\t" );
                }
                Console.WriteLine();
            }
        }
        static void maxinrow(int[][] a) // Print the biggest number of each row
        {
            for (int i = 0;i < a.Length; i++)
            {
                int max = 0;
                Console.Write($"The maximum number of the row {i}: ");
                for (int j = 0; j < a[i].Length; j++) 
                {
                    if (max < a[i][j]) 
                    {
                        max = a[i][j];                     
                    }                 
                }
                Console.Write(max);
                Console.WriteLine();
            }
        }
        static void maxinarray(int[][] a) 
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {                
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (max < a[i][j])
                    {
                        max = a[i][j];
                    }
                }               
            }
            Console.Write("The maximum number of array: ");
            Console.Write(max);
            Console.WriteLine();
        }
        static void sort_row(int[][] a) // Sort values ascending of each row.
        {
            for (int i = 0; i < a.Length ; i++) 
            { 
                for (int j = 0;j < a[i].Length - 1; j++) 
                {
                    for (int k = 0; k < a[i].Length - j - 1; k++)
                    {
                        if (a[i][k] > a[i][k+1])
                        {
                            int temp = a[i][k];
                            a[i][k] = a[i][k+1];
                            a[i][k+1] = temp;
                        }
                    }
                }
            }
            for (int i = 0;i < a.Length;i++) 
            {
                for (int j = 0; j < a[i].Length - 1; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static bool isPrime(int number) 
        {
            for (int i = 2; i <= number/2; i++)
            { 
                if (number % i == 0) 
                { 
                    return false;
                }
            }
            return true;
        }
        static void print_prime(int[][] a) //Print items of the array that are prime.
        {
            for (int i = 0; i < a.Length; i++) 
            { 
                for (int j = 0;j < a[i].Length -1; j++) 
                { 
                    if (isPrime(a[i][j])) 
                    {
                        Console.WriteLine($"{a[i][j]} appears at row {i}, col {j}");
                    }
                }
            }
        }
        static void print_position (int[][] a) // Search and print all positions of a number (enter from the user)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a.Length ; i++) 
            { 
                for (int j = 0; j <= a[i].Length - 1;j++) 
                {
                    if (num == a[i][j])
                    {
                        Console.WriteLine($"The number {num} appears at row {i}, col {j}");
                    }                  
                }
            }
        }
    }
}