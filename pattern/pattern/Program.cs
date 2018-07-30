using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for(int rowcnt=0;rowcnt<rows;rowcnt++)
            {
                for(int space=0;space<(rows-1)-rowcnt;space++)
                {
                    Console.Write(" ");
                }
                for(int star=0;star<=rowcnt;star++)
                {
                    Console.Write("*");
                       Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
