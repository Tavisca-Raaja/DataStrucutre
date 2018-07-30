using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class Anagrams
    {
        int GetMaximumSubset(string[] words)
        {
            Dictionary<int, int> StringCount = new Dictionary<int, int>();
            Dictionary<string, int> StringCheck = new Dictionary<string, int>();
            int count = 0;
            for(int index=0;index<words.Length;index++)
            {
                int ascii_count = 0;
                foreach (char str in words[index])
                    ascii_count += ((str - '0') - 48);
                
                if (!StringCount.ContainsKey(ascii_count))
                {
                    StringCount.Add(ascii_count, ++count);
                    StringCheck.Add(words[index],1);
                }
                else
                {
                    int length = words[index].Length;
                    char[] arr = words[index].ToCharArray();
                    for(int i=0;i<length;i++)
                    {
                        for(int j=0;j<length;j++)
                        {
                           if(arr[i]>arr[j])
                            {
                                char temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
                        }
                    }
                    if(!StringCheck.ContainsKey(arr.ToString()))
                        {
                        Console.WriteLine(arr.ToString());
                        StringCheck.Add(arr.ToString(), ++count);
                    }
                }
               
            }

            return count;
        }
       
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Anagrams anagramSolver = new Anagrams();
            do
            {
                string[] words = input.Split(',');
                Console.WriteLine(anagramSolver.GetMaximumSubset(words));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
/* for (int wordscount = 0; wordscount < words.Length; wordscount++)
            {
                if (StringCount.ContainsKey(words[wordscount].Length))
                    break;
                else if (wordscount == words.Length-1)
                    return words.Length;
                else
                    StringCount.Add(words[wordscount].Length, 1);
            }
            int Count = 0, flag = 0;
            int[] cntarray = new int[26];
            for (int index1=0;index1<words.Length-1;index1++)
            {

                flag = 0;
            for (int index2=index1+1;index2<words.Length;index2++)
                {
                    if(words[index1].Length==words[index2].Length)
                    {
                        foreach (char s in words[index1])
                        {
                           // Console.WriteLine(s-'0');
                            cntarray[(s - '0') - 48]++;
                        }
                            
                        foreach (char str in words[index2])
                            cntarray[(str - '0') - 48]--;
                        for(int i=0;i<26;i++)
                        {
                            if(cntarray[0]==0)
                            {
                                if (i == 25)
                                {
                                    Count++;
                                    flag = 1;
                                }
                            }
                        }
                    }
                    if (flag == 1)
                        break;
                    if (flag == 0 && index2 == words.Length - 1)
                        Count++;

                }
              


            }
*/