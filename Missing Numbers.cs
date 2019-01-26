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

    // Complete the missingNumbers function below.
    static int[] missingNumbers(int[] arr, int[] brr)
    {
        List<int> temp = brr.Distinct().ToList();
        Dictionary<int, int> result = new Dictionary<int, int>();
        temp.Sort();
        for (int i = 0; i < temp.Count; i++)
        {
            result.Add(temp[i], 0);
        }
        for (int i = 0; i < temp.Count; i++)
        {
            result[temp[i]] = brr.Count(v => v == temp[i]);
            result[temp[i]] -= arr.Count(v => v == temp[i]);
        }
        List<int> answear = new List<int>();
        for (int i = 0; i < temp.Count; i++)
        {
            if (result[temp[i]]>0)
            {
                answear.Add(temp[i]);                
            }
        }
        return answear.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int m = Convert.ToInt32(Console.ReadLine());

        int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp))
        ;
        int[] result = missingNumbers(arr, brr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
