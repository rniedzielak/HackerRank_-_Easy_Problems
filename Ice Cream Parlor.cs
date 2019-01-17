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

    // Complete the icecreamParlor function below.
    static int[]icecreamParlor(int m, int[] arr)
    {
        List<int> result = new List<int>();
        for(int i = 0; i<arr.Length; i++)
        {
            for(int j = 0; j< arr.Length; j++)
            {
                if(i!=j && arr[i]+arr[j]==m && !result.Contains(i+1) && !result.Contains(j+1))
                {
                    result.Add(i+1);
                    result.Add(j+1);
                }
            }
        }
        int[] resultArray = result.ToArray();

        return resultArray;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int m = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = icecreamParlor(m, arr);
            textWriter.WriteLine(string.Join(" ", result));
            
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
