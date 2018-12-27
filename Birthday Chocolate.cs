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

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        if (m == 0)
        {
            return 0;
        }
        else if (m == 1)
        {
            List<int> help_array = new List<int>();
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i] == d)
                {
                    help_array.Add(s[i]);
                }

            }
            return help_array.Count;
        }
        else if (m > 1)
        {
            List<int> help_array = new List<int>();
            for (int i = 0; i < s.Count - (m-1); i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += s[i + j];
                    if (sum == d && j == m - 1)
                    {
                        help_array.Add(sum);
                    }

                }

            }
            return help_array.Count;
        }
        else
        {
            return 0;
        }
 
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
