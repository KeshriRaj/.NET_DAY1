using System;

namespace ConsoleApp2
{
      
    class Program
    {
        static long factorial(int num)
        {
            long factorialValue = 1;
            while (num > 0)
            {
                factorialValue *= num;
                num--;
            }
            return factorialValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number whose Factorial to be found:");
            int num = Convert.ToInt32(Console.ReadLine());
            long factorialValue=factorial(num);
            Console.WriteLine("Factorial Value for  " + num + " = " + factorialValue);

        }
    }
}
