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

    // Complete the insertionSort1 function below.
    static void insertionSort1(int n, int[] arr)
    {
        if (n == 1)
        {
            Console.WriteLine(arr[0]);
        } 
        else
        {
            int value = arr[n - 1];
            for (int i = n - 2; i <= arr.Length; i--)
            {
                if (i == -1)
                {
                    arr[0] = value;
                    foreach(int item in arr)
                    {
                        Console.Write("{0} ", item);
                    }
                    break;
                }
                if (arr[i] > value)
                {
                    arr[i + 1] = arr[i];
                    foreach(int item in arr)
                    {
                        Console.Write("{0} ", item);
                    }
                    Console.Write("\n");
                }
                else
                {
                    arr[i + 1] = value;
                    foreach(int item in arr)
                    {
                        Console.Write("{0} ", item);
                    }
                    Console.Write("\n");
                    break;
                }
            }
        }     
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort1(n, arr);
    }
}
