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

    // Complete the nimGame function below.
    static string nimGame(int[] pile)
    {
        int xor = 0;
        for(int i = 0; i<pile.Length; i++)
        {
            xor ^=pile[i];
        }
        return xor==0 ? "Second" : "First";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine());

        for (int gItr = 0; gItr < g; gItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] pile = Array.ConvertAll(Console.ReadLine().Split(' '), pileTemp => Convert.ToInt32(pileTemp))
            ;
            string result = nimGame(pile);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
