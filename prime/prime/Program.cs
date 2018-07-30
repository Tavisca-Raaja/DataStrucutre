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
            Dictionary<long, long> PrimeNumber = new Dictionary<long,long>();
            long result = 0,NPrimeValue=0;
            
            int index1 = 0, index2 = 0, count = 0;
            bool flag = false;
           
            for (index1 = 2; count <= n; index1++)
            {
                flag = true;
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
                    PrimeNumber.Add(index1, ++count);
                }
            }
            foreach (KeyValuePair<long, long> item in PrimeNumber)
            {
                if (item.Value == n + 1)
                    NPrimeValue = item.Key*item.Key;
            }
                
            return NPrimeValue;
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
/* long res= 0;
            Dictionary<int, int> prime = new Dictionary<int, int>();
            int count = 0,index1,index2,increment=2;
            int startkey = 0,startcheck=0;
            bool flag = true;
            for (index1 = 3; count < n-1; index1++)
            {
                flag = true;
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
                    prime.Add(index1,++count);
                }
            }
            foreach (KeyValuePair<int, int> item in prime)
            {
                //Console.WriteLine("item:"+item.Key);
                if (item.Value == n-1)
                    startkey = item.Key;
            }
            flag = true;
          
                startkey = (startkey * 2) + 1;
           
          //  Console.WriteLine(startkey);
            while (flag)
            {
                flag = true;
                startcheck = 0;
                foreach (KeyValuePair<int,int> item1 in prime)
                {
                   // Console.WriteLine(startkey+" % "+item1.Key+" "+startcheck);
                    if ((startkey % item1.Key) != 0)
                    {
                        startcheck++;
                        if (startcheck == prime.Count)
                        {
                            if (check(startkey))
                            {
                                flag = false;
                                res = startkey;
                               // Console.WriteLine(startkey);
                                break;
                            }
                            
                                
                           
                        }
                                              
                    }
                    else
                    {
                       
                        break;
                    }
                       
                }
                startkey += 2;
            }

                    return res;
*/