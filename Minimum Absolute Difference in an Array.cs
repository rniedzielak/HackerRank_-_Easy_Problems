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

    // Complete the minimumAbsoluteDifference function below.
    static int minimumAbsoluteDifference(int[] arr)
    {
        Array.Sort(arr);
        List<int> help = new List<int>();
        for (int i = 0, j = 1; i < arr.Length-1 && j < arr.Length; i++, j++)
        {
            help.Add(Math.Abs(arr[j] - arr[i]));
        }
        help.Sort();
        return help[0];
    }
    
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = minimumAbsoluteDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
