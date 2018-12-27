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

    // Complete the findDigits function below.
    static int findDigits(int n)
    {
        List<int> dividers = new List<int>();
        List<int> dividersPassed = new List<int>();
        string number = n.ToString();
        char[] numberToString = new char[number.Length];
        for (int i = 0; i < numberToString.Length; i++)
        {
            numberToString[i] = number[i];
        }
        for (int i = 0; i < numberToString.Length; i++)
        {
            if (numberToString[i] == '0')
            {
                continue;
            }
            else
            {
                dividers.Add(Convert.ToInt32(numberToString[i].ToString())); 
            }
        }
        for (int i = 0; i < dividers.Count; i++)
        {
            if (n % dividers[i] == 0)
            {
                dividersPassed.Add(dividers[i]);
            }
        }
        return dividersPassed.Count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
