using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    public class EngineersPrimes
    {
        long SmallestNonPrime(int n)
        {
            long NonPrime = 0;
            long[] PrimeNumbers = new long[100000];
            int PrimeNumbersCount = 0;
           for(int index1=2;index1< 10;index1++)
                {
                
                for(int index2=2;index2<=index1;index2++)
                {
                    Console.WriteLine(index1 + " % " + index2);
                    if (index2 == index1)
                        PrimeNumbers[PrimeNumbersCount++] = index1;
                    else if (index1 % index2 == 0)
                        break;
                }
                }
            for (int index3 = 0; index3 < 10; index3++)
                Console.WriteLine(PrimeNumbers[index3]);

            
            return Int64.MinValue;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            EngineersPrimes engineersPrimes = new EngineersPrimes();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(engineersPrimes.SmallestNonPrime(Int32.Parse(input)));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}