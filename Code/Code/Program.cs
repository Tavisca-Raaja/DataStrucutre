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
            Dictionary<int, int> PrimeNumber = new Dictionary<int, int>();
            Dictionary<int, int> PrimeNumberN = new Dictionary<int, int>();
            int PrimeNumberCount = 0, index1, index2, StartIndex = 0;
            bool flag = true;
            bool flag1 = true;
            int count = 0;
            int c = 0;
            for (index1 = 2; index1 < 100000; index1++)
            {
                flag = true;
                //Console.WriteLine(PrimeNumberCount+" "+index1);
                for (index2 = 2; index2 <= Math.Sqrt(index1); index2++)
                {

                    if (index1 % index2 == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    if (PrimeNumberCount < n)
                        PrimeNumberN.Add(index1, ++PrimeNumberCount);
                    PrimeNumber.Add(index1, ++PrimeNumberCount);

                }
            }
            foreach (KeyValuePair<int, int> pair in PrimeNumberN)
            {
                if (pair.Value == n)
                    StartIndex = pair.Key;
                c++;
                
            }
            Console.WriteLine(c);
            for (int NonPrime = StartIndex; flag1 != false; NonPrime++)
            {
                count = 0;
                if (!PrimeNumber.ContainsKey(NonPrime))
                    foreach (KeyValuePair<int, int> pair1 in PrimeNumberN)
                    {
                        Console.WriteLine(NonPrime + " % " + pair1.Key + " " + count + " " + PrimeNumberN.Count);
                        if (NonPrime % pair1.Key == 0)
                            break;
                        else if (NonPrime % pair1.Key != 0)
                        {
                            count++;
                            if (count == PrimeNumberN.Count)
                            {
                                Console.WriteLine(NonPrime);
                                flag1 = false;
                            }
                        }

                    }
            }


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

