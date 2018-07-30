using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class TriFibonacci
    {
        public int Complete(int[] test)
        {
            int length = test.Length;
            int FindPosition = 0, flag = 0;
            for (int index1 = 0; index1 < length; index1++)
            {
                if (test[index1] == -1)
                {
                    FindPosition = index1 + 1;
                    break;
                }
              
            

            }
            //test[FindPosition - 1] = -1;
            for (int index = 3; index < length; index++)
            {
                if (test[index] != test[index - 1] + test[index - 2] + test[index - 3])
                {
                    if (test[index] == -1)
                        test[index] = test[index - 1] + test[index - 2] + test[index - 3];
                    else if (test[FindPosition - 1] == -1 && (test[index] - (test[index - 1] + test[index - 2] + test[index - 3]) - 1)>0)
                    {
                       
                            test[FindPosition - 1] =test[index]- (test[index - 1] + test[index - 2] + test[index - 3])-1;
                       
                    }
                        
                    else
                        return -1;
        }
                }
            if (test[FindPosition - 1] == 0)
                return -1;
            return test[FindPosition - 1];
        }

            
        

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
                string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
