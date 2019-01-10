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

    // Complete the stringConstruction function below.
    static int stringConstruction(string s)
    {
        int result = 0;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] alpha = alphabet.ToCharArray();
        int[] helpingArray = new int[alpha.Length];
        for(int i = 0; i < helpingArray.Length; i++)
        {
            helpingArray[i] = s.Count(x => x==alpha[i]);
        }
        foreach(int item in helpingArray)
        {
            if(item > 0)
            {
                result++;
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = stringConstruction(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
