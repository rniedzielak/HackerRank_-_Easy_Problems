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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        double positive = 0;
        double negative = 0;
        double zeros = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0)
            {
                positive++;
            }
            else if (arr[i] == 0)
            {
                zeros++;
            }
            else
            {
                negative++;
            }
        }
        double line_one=positive/arr.Length;
        double line_two=negative/arr.Length;
        double line_three=zeros/arr.Length;
        Console.WriteLine(line_one);
        Console.WriteLine(line_two);
        Console.WriteLine(line_three);             
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
