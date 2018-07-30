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
            for (index1 = 2; index1< 100000; index1++)
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
                    if(c<n)
                    PrimeNumberN.Add(index1, ++c);
                    PrimeNumber.Add(index1, ++PrimeNumberCount);

                }
            }
            foreach (KeyValuePair<int, int> pair in PrimeNumberN)
            {
                Console.WriteLine(pair.Key);
                if (pair.Value == n)
                    StartIndex = pair.Key;

            }
           // Console.WriteLine("pp: "+PrimeNumberN.Count);
            for (int NonPrime = StartIndex; flag1 != false; NonPrime++)
            {
                count = 0;
                if(!PrimeNumber.ContainsKey(NonPrime))
                    foreach (KeyValuePair<int, int> pair1 in PrimeNumberN)
                    {
                       // Console.WriteLine(NonPrime + " % " + pair1.Key+" "+count+" "+ PrimeNumberN.Count);
                        if (NonPrime % pair1.Key == 0)
                            break;
                        else if (NonPrime % pair1.Key != 0)
                        {
                            count++;
                            if (count == (PrimeNumberN.Count))
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

/*long NonPrime = 0;
            long[] PrimeNumbers = new long[100000];
            long[] NotPrime = new long[100000];
            int PrimeNumbersCount = 0;
            for (int index1 = 2; PrimeNumbersCount<n; index1++)
            {

                for (int index2 = 2; index2 <= index1; index2++)
                {
                    if (index2 == index1)
                        PrimeNumbers[PrimeNumbersCount++] = index1;
                    else if (index1 % index2 == 0)
                    {
                        
                        break;
                    }
                }
            }
     

            int flag = 0;
            for(int c=0;flag<1;c++)
            {
                for (int i = 0; i < n; i++)
                   
                {
                    //Console.WriteLine(c+" %"+PrimeNumbers[i]);
                    if (NotPrc] % PrimeNumbers[i] != 0 && i == n - 1)
                    {
                        Console.WriteLine("c:"+NotPrime[c]);
                        flag = 1;
                    }
                    else if (NotPrime[c] % PrimeNumbers[i] == 0)
                        break;
                }

            }
*/