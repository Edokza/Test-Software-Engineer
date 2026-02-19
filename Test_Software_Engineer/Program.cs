using System;

namespace Test_Software_Engineer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntToAlien converter = new IntToAlien();
            AlienToInt reverseConverter = new AlienToInt();

            Console.WriteLine("Alien Converter");

            while (true)
            {
                Console.Write("\nInput: ");
                string input = Console.ReadLine();

                if(input.ToLower() == "exit")
                    break;

                if(int.TryParse(input, out int number))
                {
                    string result = new IntToAlien().Converting(number);
                    Console.WriteLine($"Output: {result}");
                }
                else if(reverseConverter.IsAlienFormat(input))
                {
                    int result = reverseConverter.Converting(input.ToUpper());
                    Console.WriteLine($"Output: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input format.");
                }
            }

            Console.WriteLine("Program ended.");
        }
    }
}