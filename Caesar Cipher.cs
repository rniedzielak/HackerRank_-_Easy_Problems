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

class Solution
{
    // Complete the caesarCipher function below.
    static string caesarCipher(string s, int k)
    {
        if (k <= 26)
        {
            return k_is_less_than_26(s, k);
        }
        else
        {
            return k_is_more_than_26(s, k);
        }
    }
    // if someone want to type k like troll
    static string k_is_more_than_26(string s, int k)
    {
        int move = k % 26;
        return k_is_less_than_26(s, move);
    }
    // normal right mouveing letters
    static string k_is_less_than_26(string s, int k)
    {
        char[] before = s.ToCharArray();
        char[] after = new char[s.Length];
        for (int i = 0; i < before.Length; i++)
        {
            if (Char.IsLower(before[i]))
            {
                if (before[i] + k <= 122)
                {
                    after[i] = (char)(before[i] + k);
                }
                else
                {
                    after[i] = (char)(before[i] - (26 - k));
                }
            }
            else if (char.IsUpper(before[i]))
            {
                if (before[i] + k <= 90)
                {
                    after[i] = (char)(before[i] + k);
                }
                else
                {
                    after[i] = (char)(before[i] - (26 - k));
                }
            }
            else
            {
                after[i] = before[i];
            }
        }
        string result = "";
        foreach (var item in after)
        {
            result += item;
        }
        return result;
    }

    static void Main(string[] args) 
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        string result = caesarCipher(s, k);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
