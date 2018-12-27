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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) 
    {
        List<int> counter1 = new List<int>();
        List<int> counter2 = new List<int>();
        List<int> counter3 = new List<int>();
        List<int> counter4 = new List<int>();
        List<int> counter5 = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] == 1)
            {
                counter1.Add(arr[i]);
            }
            else if (arr[i] == 2)
            {
                counter2.Add(arr[i]);
            }
            else if (arr[i] == 3)
            {
                counter3.Add(arr[i]);
            }
            else if (arr[i] == 4)
            {
                counter4.Add(arr[i]);
            }
            else if (arr[i] == 5)
            {
                counter5.Add(arr[i]);
            }
            else
            {
                return 0;
            }
        }
        int counter = arr.GroupBy(v => v)
                         .Max(v => v.Count());
        if (counter1.Count == counter)
        {
            return 1;
        }
        else if (counter2.Count == counter)
        {
            return 2;
        }
        else if(counter3.Count == counter)
        {
            return 3;
        }
        else if(counter4.Count == counter)
        {
            return 4;
        }
        else if(counter5.Count == counter)
        {
            return 5;
        }
        else
        {
            return 0;
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
