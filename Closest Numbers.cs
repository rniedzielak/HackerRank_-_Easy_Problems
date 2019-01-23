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

    // Complete the closestNumbers function below.
    static int[] closestNumbers(int[] arr)
    {
        Array.Sort(arr);
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (Math.Abs(arr[i+1]-arr[i]) < min)
            {
                min = Math.Abs(arr[i + 1] - arr[i]);
            }
        }
        List<int> minPairs = new List<int>();
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (Math.Abs(arr[i + 1] - arr[i]) == min)
            {
                minPairs.Add(arr[i]);
                minPairs.Add(arr[i + 1]);
            }
        }
        int[] result = minPairs.ToArray();
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] result = closestNumbers(arr);
        textWriter.WriteLine(string.Join(" ", result));
        textWriter.Flush();
        textWriter.Close();
    }
}
