using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            int[,] arr = new int[s1.Length+1,s2.Length+1];
            
            for(int row=1;row<=s2.Length;row++)
            {
                for(int column=1;column<=s1.Length;column++)
                {
                    if (s1[column-1] == s2[row-1])
                    {
                        Console.WriteLine(row+" "+column);
                        arr[row,column] = arr[row - 1,column - 1] + 1;
                        //Console.WriteLine(arr[row,column]+" "+" "+row+" "+column);
                    }
                    else
                    {
                        int temp = (arr[row - 1, column] > arr[row, column - 1]) ? arr[row - 1, column] : arr[row, column - 1];
                        arr[row, column] = temp;
                        
                    }
                   
                }
            }
            for (int row = 0; row < s1.Length+1; row++)
            {
                for (int column = 0; column < s2.Length+1; column++)
                {
                    Console.Write(arr[row,column]+" ");
                }
                Console.WriteLine();
            }
                    Console.WriteLine(arr[s1.Length, s2.Length]);
        }
    }
}
