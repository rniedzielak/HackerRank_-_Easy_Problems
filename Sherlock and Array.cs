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

    // Complete the balancedSums function below.
    static string balancedSums(List<int> arr) 
    {
        if (arr.Count ==1)
        {
            return "YES";
        }
        else if(arr.Count(v => v==0) == arr.Count - 1)
        {
            return "YES";
        }
        else
        {
            int n = arr.Count;
            int i = 0;
            int j = n-1;
            int left = 0;
            int right = 0;
            while (i < n && j >= 0)
            {
                if (left == right && i == j)
                {
                    return "YES";
                }
                if (left > right)
                {
                    right += arr[j];
                    j--;
                }
                else
                {
                    left += arr[i];
                    i++;
                }
            }
            return "NO";
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++) {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = balancedSums(arr);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
