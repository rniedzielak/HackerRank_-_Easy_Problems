//My first solution pass all cases except one here not best solution:
/*
// Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c)
    {
        List<int> helpingList = new List<int>();
        if (c.Length == n)
            return 0;
        else
        {
            for (int i = 0; i < n; i++)
            {
                List<int> helpingList2 = new List<int>();
                for (int j = 0; j < c.Length; j++)
                {
                    if (c[j]==i)
                    {
                        helpingList2.Add(0);
                    }
                    else
                    {
                        helpingList2.Add(Math.Abs(i - c[j]));
                    }
                    
                }
                helpingList.Add(helpingList2.Min());
            }
        }
        return helpingList.Max();  */
        
// My final O(n) solution:
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

    // Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c)
    {
        if (c.Length == n)
            return 0;
        int first = 0;
        int last = n - 1;
        Array.Sort(c);
        int max = c[0] * 2;
        for (int i = 0; i < c.Length; i++)
        {
            if (max < c[i] - first)
            {
                max = c[i] - first;
            }
            first = c[i];
        }
        if (max < (last - first) * 2)
        {
            max = (last - first) * 2;
        }
        return max / 2;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = flatlandSpaceStations(n, c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
