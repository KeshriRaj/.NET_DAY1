using System;

namespace ConsoleApp1
{
    class Program
    {
        static int CountNumberDivisibleByThree()
        {
        int count = 0;
        Console.WriteLine("******************************NUMBERS DIVISIBLE BY 3 :-********************************************");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine();
            return count;
        }

        static void Main(string[] args)
        {
            int count = CountNumberDivisibleByThree();
            Console.WriteLine("Total Count of Numbers Divisible By 3 = " + count);
        }
       
    }
}
