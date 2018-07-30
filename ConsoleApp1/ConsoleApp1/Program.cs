using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;

using System.Text.RegularExpressions;
using System.Text;
using System;

class program
{

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2)
    {
        int ptr = 0;
        for (int index1 = 0; index1 < s1.Length; index1++)
        {
            ptr = index1;
            for (int index2 = 0; index2 < s2.Length; index2++)
            {
                if (s1[ptr] == s2[index2])
                {
                    Console.WriteLine(s1[ptr] + " " + s2[(index2)] + " " + ptr);
                    if (ptr < s1.Length)
                        ptr++;

                }
            }
        }
        return 0;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = commonChild(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        //textWriter.Close();
    }
}
