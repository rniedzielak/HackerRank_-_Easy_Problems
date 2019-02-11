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

class Solution
{
    // Complete the largestPermutation function below.
    static int[] largestPermutation(int k, int[] arr)
    {
      //This is my last solution from Easy problems ---> FINISH
        int[] NaturalNumbersIndexes = new int[arr.Length + 1];
        
        for(int i = 0; i < arr.Length; i++)
            NaturalNumbersIndexes[arr[i]] = i;
        
        int swapCount = 0;
        for (int i = arr.Length; i > 0; i--)
        {
            if (swapCount == k)
                break;
            if (arr[arr.Length - i] != i)
            {
                arr[NaturalNumbersIndexes[i]] = arr[arr.Length - i];
                NaturalNumbersIndexes[arr[arr.Length - i]] = NaturalNumbersIndexes[i];
                arr[arr.Length - i] = i;
                NaturalNumbersIndexes[i] = arr.Length - i;
                swapCount++;
            }
        }
        return arr;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string[] nk = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] result = largestPermutation(k, arr);
        textWriter.WriteLine(string.Join(" ", result));
        textWriter.Flush();
        textWriter.Close();
    }
}
