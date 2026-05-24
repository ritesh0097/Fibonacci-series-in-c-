using System;

namespace Tribonacci_Series
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int b = 1; int c = 1;

            Console.Write("Enter the lenght of tribonacci series: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.Write($"{a} ");

                int temp = a + b + c;
                a = b;
                b = c;
                c = temp;
            }

        }
    }

}