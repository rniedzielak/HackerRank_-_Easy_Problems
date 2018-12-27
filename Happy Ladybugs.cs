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

    // Complete the happyLadybugs function below.
        static string happyLadybugs(string b)
    {
        foreach (char item in b)
        {
            if (item !='_' && b.Count(v => v == item) == 1)
            {
                return "NO";
            }
        }
        if (b.Count(v=>v=='_') == 0)
        {
            for (int i = 1; i < b.Length-1; i++)
            {
                if (b[i - 1] != b[i] && b[i + 1]!= b[i])
                {
                    return "NO";
                }
            }                
        }
        return "YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int g = Convert.ToInt32(Console.ReadLine());
        for (int gItr = 0; gItr < g; gItr++) {
            int n = Convert.ToInt32(Console.ReadLine());
            string b = Console.ReadLine();
            string result = happyLadybugs(b);
            textWriter.WriteLine(result);
        }
        textWriter.Flush();
        textWriter.Close();
    }
}
