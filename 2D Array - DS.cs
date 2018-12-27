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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        List<int> find_max = new List<int>();
        for (int i = 5; i >= 2; i--)
        {
            for (int j = 5; j >= 2; j--)
            {
                int sum = arr[i][j] + arr[i][j - 1] + arr[i][j - 2] + arr[i - 1][j - 1] + arr[i-2][j] + arr[i - 2][j - 1] + arr[i - 2][j - 2];
                find_max.Add(sum);
            }
        }
        int a = -82;
        for (int i = 0; i < find_max.Count; i++)
        {
            if (find_max[i]>a)
            {
                a = find_max[i];
            }
            else
            {
                continue;
            }
        }
        return a;
    }

        static void Main(string[] args) 
        {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
