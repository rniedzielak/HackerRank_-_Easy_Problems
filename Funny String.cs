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

    // Complete the funnyString function below.
    static string funnyString(string s)
    {
        char[] a = s.ToCharArray();
        int[] before = new int[a.Length - 1];
        for(int i = 1; i < a.Length; i++)
        {
            before[i-1] = Math.Abs((int)a[i]-(int)a[i-1]);
        }
        Array.Reverse(a);
        int[] after = new int[a.Length - 1];
        for(int i = 1; i < a.Length; i++)
        {
            after[i-1] = Math.Abs((int)a[i]-(int)a[i-1]);
        }
        for(int i = 0; i < before.Length; i++)
        {
            if(before[i]!=after[i])
            {
                return "Not Funny";
            }
        }
        return "Funny";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            string result = funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
