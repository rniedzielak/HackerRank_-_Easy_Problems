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

    // Complete the quickSort function below.
    static int[] quickSort(int[] arr)
    {
        int p = arr[0];
        List<int> left = new List<int>();
        List<int> equal = new List<int>();
        List<int> right = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == p)
            {
                equal.Add(arr[i]);
            }
            else if (arr[i] > p)
            {
                right.Add(arr[i]);
            }
            else
            {
                left.Add(arr[i]);
            }
        }
        int[] result = left.Concat(equal)
                           .Concat(right)
                           .ToArray();
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] result = quickSort(arr);
        textWriter.WriteLine(string.Join(" ", result));
        textWriter.Flush();
        textWriter.Close();
    }
}
