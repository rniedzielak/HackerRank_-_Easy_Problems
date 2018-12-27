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

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr) 
    {
        List<int> helpArr = arr.ToList();
        List<int> helpArr2 = arr.ToList();
        List<int> helpArr3 = helpArr.Distinct().ToList();
        helpArr3.Sort();
        int[] result = new int[helpArr3.Count];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = (from n in helpArr2
                         where n >= helpArr3[i]
                         select n).Count();
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
