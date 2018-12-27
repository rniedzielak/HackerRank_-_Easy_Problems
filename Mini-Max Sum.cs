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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        Array.Sort(arr);
        long suma_min = 0;
        long suma_max = 0;
        for(int i = 0; i < arr.Length - 1;i++)
        {
            suma_min += arr[i];
        }
        for (int i = arr.Length - 1; i > 0; i--)
        {
            suma_max += arr[i];
        }
        Console.WriteLine("{0} {1}", suma_min, suma_max);

    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
