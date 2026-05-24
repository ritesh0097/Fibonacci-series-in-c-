using System;

namespace Armstrong_Numbers
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int a, b, c, rev_num;

            a = num/100;
            b = (num/10)%10;
            c = num%10;

            rev_num = a*a*a+b*b*b+c*c*c;

            if(num == rev_num)
            {
                Console.WriteLine("Your number is Armstrong number: ");
            }
            else
            {
                Console.WriteLine("Your number is not Armstrong number: ");
            }



            

        }
    }

}