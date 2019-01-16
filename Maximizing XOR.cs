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

    // Complete the maximizingXor function below.
    static int maximizingXor(int l, int r)
    {
        int sum = 0;
        int max = 0;
        int i;
        int iteration = r - l + 1;
        while(iteration-->1)
        {
            for (i = l;i < r; i++)
            {
                sum = i^(i+1);
                if(sum>max)
                {
                    max = sum;
                }
            }
            i++;
        }
        return max;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine());

        int r = Convert.ToInt32(Console.ReadLine());

        int result = maximizingXor(l, r);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
