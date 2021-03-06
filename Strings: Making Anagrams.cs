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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b)
    {
        int[] lettercounter = new int[26];
        foreach (char letter in a.ToCharArray())
        {
            lettercounter[letter-'a']++;
        }
        foreach (var letter in b.ToCharArray())
        {
            lettercounter[letter - 'a']--;
        }
        int result = 0;
        for (int i = 0; i < lettercounter.Length; i++)
        {
            result += Math.Abs(lettercounter[i]); 
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
