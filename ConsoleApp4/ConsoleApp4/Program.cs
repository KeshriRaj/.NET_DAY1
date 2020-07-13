using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                Console.WriteLine("This is Number " + (i + 1));
            }
        }
    }
}
