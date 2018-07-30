using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acgt
{
    namespace CodeJam
    {
        class ACGT
        {
            int MinChanges(int maxPeriod, string[] acgt)
            {

                string TotalString = "";
                int length = acgt.Length;
                int maxCount = int.MaxValue,count=int.MaxValue;
                int periodIndex = 0;
                for (int index = 0; index < length; index++)
                    TotalString += acgt[index];
                int newLength = TotalString.Length;
                if (maxPeriod == TotalString.Length)
                    return 0;
                int[] arr = new int[4];

                for (int j = 0; j < length; j++)
                {
                    if (acgt[j] == "a")
                        ++arr[0];
                    if (acgt[j] == "c")
                        arr[1]++;
                    if (acgt[j] == "g")
                        arr[2]++;
                    if (acgt[j] == "t")
                        arr[3]++;
                }
                for (int i = 0; i < arr.Length; i++)
                    Console.WriteLine(arr[i]);
                return 0;
            }

            #region Testing code Do not change
            public static void Main(String[] args)
            {
                ACGT aCGT = new ACGT();
                String input = Console.ReadLine();
                do
                {
                    var inputParts = input.Split('|');
                    int maxPeriod = int.Parse(inputParts[0]);
                    string[] acgt = inputParts[1].Split(',');
                    Console.WriteLine(aCGT.MinChanges(maxPeriod, acgt));
                    input = Console.ReadLine();
                } while (input != "-1");
            }
            #endregion
        }
    }
}