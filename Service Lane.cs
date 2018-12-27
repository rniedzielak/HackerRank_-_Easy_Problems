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

    // Complete the serviceLane function below.
    static int[] serviceLane(int n, int[][] cases, int[] width)
    {        
        int[] result = new int[cases.Length];
        List<int> newList = new List<int>();
        for(int i = 0; i<cases.Length; i++)
        {
            for(int j = 0; j < cases[i].Length; j++)
            {
                newList = width.Skip(cases[i][0]).Take(cases[i][1]-cases[i][0]+1).ToList();
                result[i]=newList.Min();
                newList.Clear();
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nt = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nt[0]);

        int t = Convert.ToInt32(nt[1]);

        int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
        ;

        int[][] cases = new int[t][];

        for (int i = 0; i < t; i++) {
            cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
        }

        int[] result = serviceLane(n, cases, width);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
