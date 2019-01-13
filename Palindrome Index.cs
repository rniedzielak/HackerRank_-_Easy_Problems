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

    // Complete the palindromeIndex function below.
    static int palindromeIndex(string s)
    {
        for(int i =0,j = s.Length - 1; i<j; i++, j--)
        {
            if(s[i]!=s[j])
            {
                if(isPalindrome(s, i))
                    return i;
                else if(isPalindrome(s, j))
                    return j;
            }
        }
        return -1;
    }
    
    static bool isPalindrome(string s, int index)
    {
        for(int i =index+1,j =s.Length - 1 - index; i<j; i++, j--)
        {
            if(s[i]!=s[j])
                return false;
        }
        return true;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = palindromeIndex(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
