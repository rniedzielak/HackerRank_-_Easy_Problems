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

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr)
    {
        int mode = arr.GroupBy(v => v)
                      .OrderByDescending(g => g.Count())
                      .First()
                      .Key;
        List<int> help = new List<int>();
        for(int i = 0; i<arr.Length; i++)
        {
            if(arr[i]==mode)
            {
                help.Add(arr[i]);
            }
        }
        int result = arr.Length - help.Count;
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
