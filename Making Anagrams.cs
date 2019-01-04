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

    // Complete the makingAnagrams function below.
    static int makingAnagrams(string s1, string s2)
    {
        int result = 0;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] alpha = alphabet.ToCharArray();
        int[] helpingArray = new int[alpha.Length];
        for(int i = 0; i<helpingArray.Length; i++)
        {
           helpingArray[i] = s1.Count(x => x==alpha[i]);
           helpingArray[i] -=s2.Count(x => x==alpha[i]);
        }
        foreach(int item in helpingArray)
        {
            result += Math.Abs(item);
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int result = makingAnagrams(s1, s2);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
