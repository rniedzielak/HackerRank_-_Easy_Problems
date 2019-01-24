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

    // Complete the weightedUniformStrings function below.
    static string[] weightedUniformStrings(string s, int[] queries)
    {
        char[] charArray = s.ToCharArray();
        int contigentString = 1;
        int lastAlphaNum = 0;
        HashSet<int> base_of_combinations = new HashSet<int>();
        for (int i = 0; i < charArray.Length; i++)
        {
            int alphaNum = charArray[i] - 96;
            if (alphaNum == lastAlphaNum)
            {
                contigentString++;
            }
            else
            {
                contigentString = 1;
                lastAlphaNum = alphaNum;
            }
            int num = alphaNum * contigentString;
            base_of_combinations.Add(num);
        }
        string[] result = new string[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            if (base_of_combinations.Contains(queries[i]))
            {
                result[i] = "Yes";
            }
            else
            {
                result[i] = "No";
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        int[] queries = new int [queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        string[] result = weightedUniformStrings(s, queries);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
