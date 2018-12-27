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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long result = 0;
        if (s=="a")
        {
            return n;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                result++;
            }
        }
        result = result * Convert.ToInt64(Math.Floor(Convert.ToDouble(n)/s.Length));
        long rest = n % s.Length;
        for (int i = 0; i < rest; i++)
        {
            if (s[i] == 'a')
            {
                result++;
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
