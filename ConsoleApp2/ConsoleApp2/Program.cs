using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBERS:");
            int number1 =Convert.ToInt32( Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            number1 = number1 ^ number2;
            number2 = number1 ^ number2;
            number1 = number1 ^ number2;
            Console.WriteLine(number1 + " " + number2);
        }
    }
}
