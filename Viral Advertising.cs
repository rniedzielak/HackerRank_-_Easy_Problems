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

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n)
    {
        double shared = 0;
        int liked = 0;
        int cumulative = 0;
        for (int i = 1; i<=n; i++)
        {
            if (i == 1)
            {
                shared = 5;
                liked = Convert.ToInt32(Math.Floor(shared/2));
                cumulative += liked;
            }
            else
            {
                shared = liked * 3;
                liked = Convert.ToInt32(Math.Floor(shared/2));
                cumulative += liked;
            }
        }

        return cumulative;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
