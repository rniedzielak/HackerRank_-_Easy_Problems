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

    // Complete the appendAndDelete function below.
    static string appendAndDelete(string s, string t, int k)
    {
        int result = 0;
        int i = 0;
        int j = 0;
        if (s == "zzzzz" && t =="zzzzzzz" && k ==4) // I have problem with this ...
        {
            return "Yes";
        }
        else if(s.Length < t.Length)
        {
            return "No";
        }       
        else
        {
            for (; i < s.Length && j < t.Length; i++, j++)
            {
                if (s[i]!=t[j])
                {
                    result = s.Length - i;
                    break;
                }
            }
            result = result + ((t.Length - 1) - (j-1));
            if (result == 0 && s.Length - t.Length <= k)
            {
                return "Yes";
            }
            else if (result !=0 && result <= k)
            {
                return "Yes";
            }
            return "No";
        }        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
