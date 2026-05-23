using System;
using System.Diagnostics.Contracts;
using System.Net;
using Microsoft.Win32;

namespace Fibonacci_Series
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 1;

            Console.Write("Enter the lenght of febonacci series: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.Write($"{a} ");

                int temp = a + b;
                a = b;
                b = temp;
            }

        }
    }

}