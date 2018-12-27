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

    // Complete the fairRations function below.
    static void fairRations(int[] B)
    {
        int counter = 0;
        
        for(int i = 0; i < B.Length - 1; i++)
        {
            if(B[i]%2==0)
            {
                continue;
            }
            if(B[i]%2!=0)
            {
                B[i]++;
                B[i+1]++;
                counter+=2;
            }
        }
        for(int i = 0; i < B.Length; i++)
        {
            if(B[i]%2!=0)
            {
                Console.WriteLine("NO");
                break;
            }
            if(B[i]%2==0 && i == B.Length-1)
            {
                Console.WriteLine(counter);
            }
        }
    }

    static void Main(string[] args) {

        int N = Convert.ToInt32(Console.ReadLine());

        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));
        fairRations(B);

    }
}
