using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            string[] words = name.Split(' ');
            if(words.Length==1)
            {
                Console.WriteLine("You have entered " + name + " which has length of "+name.Length+" characters");
            }
            else
            {
                Console.WriteLine("Hello your sentence contains "+words.Length+ " words.Your third word is '" + words[2]+ "'");
            }

        }
    }
}
