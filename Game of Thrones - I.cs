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

    // Complete the gameOfThrones function below.
   static string gameOfThrones(string s)
    {
        int[] numbersOfLetters = new int[s.GroupBy(v => v).Count()];
        if (s.Length % 2 == 0)
        {
            for (int i = 0; i < numbersOfLetters.Length; i++)
            {
                numbersOfLetters[i] = s.GroupBy(v => v).ToList()[i].Count();
            }
            for (int i = 0; i < numbersOfLetters.Length; i++)
            {
                if (numbersOfLetters[i] % 2!=0)
                {
                    return "NO";
                }
            }
            return "YES";
        }
        else
        {
            for (int i = 0; i < numbersOfLetters.Length; i++)
            {
                numbersOfLetters[i] = s.GroupBy(v => v).ToList()[i].Count();
            }
            int counter = 0;
            for (int i = 0; i < numbersOfLetters.Length; i++)
            {
                if (numbersOfLetters[i] % 2 != 0)
                {
                    counter++;
                }
            }
            if (counter==1)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
