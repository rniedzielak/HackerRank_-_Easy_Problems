using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
       List<int> helping_list = new List<int>();
        int result = 0;
        int helping_value = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c =='U')
            {
                helping_value++;
                helping_list.Add(helping_value);
            }
            if (c == 'D')
            {
                helping_value--;
                helping_list.Add(helping_value);
            }
        }
        for (int i = 0; i < helping_list.Count; i++)
        {
            if (helping_list[i] == 0 && helping_list[i-1] == -1)
            {
                result++;
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
