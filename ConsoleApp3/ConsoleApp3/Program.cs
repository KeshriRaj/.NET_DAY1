using System;

namespace ConsoleApp3
{
    class Program
    {
        static int GetMaxNumber(string num)
        {
            int maxValue = Int32.MinValue;
            string[] numbers = num.Split(',');
            for(int i=0;i<numbers.Length;i++)
            {
                if(maxValue<Convert.ToInt32(numbers[i]))
                {
                    maxValue = Convert.ToInt32(numbers[i]);
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers seperated by commas");
            string numbers = Console.ReadLine();
            int  maxValue=GetMaxNumber(numbers);
            Console.WriteLine("Maximum Value in Bunch Of Numbers  " + numbers + " = " + maxValue);

        }
    }
}
