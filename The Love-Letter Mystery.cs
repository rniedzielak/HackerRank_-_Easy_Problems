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
    // Complete the theLoveLetterMystery function below.
    static int theLoveLetterMystery(string s)
    {
        int result = 0;
        if(s.Length%2==0)
        {
            string s1 = s.Substring(0,s.Length/2);
            string s2 = s.Substring(s.Length/2);
            char[] s2arr = s2.ToCharArray();
            Array.Reverse(s2arr);
            for(int i = 0; i<s1.Length; i++)
            {
                if(s1[i]!=s2arr[i])
                {
                    result += Math.Abs((int)s1[i]-(int)s2arr[i]);
                }
            }
        }
        else
        {
            string after_remove = s.Remove((int)Math.Floor((double)s.Length/2), 1);
            string s1 = after_remove.Substring(0,after_remove.Length/2);
            string s2 = after_remove.Substring(after_remove.Length/2);
            char[] s2arr = s2.ToCharArray();
            Array.Reverse(s2arr);
            for(int i = 0; i<s1.Length; i++)
            {
                if(s1[i]!=s2arr[i])
                {
                    result += Math.Abs((int)s1[i]-(int)s2arr[i]);
                }
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int q = Convert.ToInt32(Console.ReadLine());
        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();
            int result = theLoveLetterMystery(s);
            textWriter.WriteLine(result);
        }
        textWriter.Flush();
        textWriter.Close();
    }
}
