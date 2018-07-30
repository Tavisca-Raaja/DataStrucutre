using System;

namespace Code
{
    class ACGT
    {
        int MinChanges(int maxPeriod, string[] acgt)
        {

            int MinCount = Int32.MaxValue, count = 0, rotate = 0;
            string s = "", s1 = "";
            string act = "";
            foreach (string str in acgt)
                act += str;

            for (int index = 1; index <= maxPeriod; index++)
            {
                count = 0;rotate = 0;
                for (int index2 = index; index2 < act.Length; index2++)
                {

                    if (act[rotate] != act[index2])
                    {
                        count++;

                    }
                    Console.WriteLine(act[rotate] + " " + act[index2] + " " + count);
                    rotate++;
                    if (rotate == index)
                        rotate = 0;
                    
                }
                if (count < MinCount)
                    MinCount = count;
            }

            return MinCount;
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
