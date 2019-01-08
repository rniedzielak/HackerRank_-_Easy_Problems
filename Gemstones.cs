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

    // Complete the gemstones function below.
    static int gemstones(string[] arr)
    {
        int result = 0;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] alpha = alphabet.ToCharArray();
        for(int i =0; i<alpha.Length; i++)
        {
            for(int j = 0; j<arr.Length; j++)
            {
                if(!arr[j].Contains(alpha[i]))
                {
                    break;
                }
                else if(arr[j].Contains(alpha[i]) && j==arr.Length-1)
                {
                    result++;
                }
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string [n];

        for (int i = 0; i < n; i++) {
            string arrItem = Console.ReadLine();
            arr[i] = arrItem;
        }

        int result = gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
