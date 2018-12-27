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

    // Complete the utopianTree function below.
    static int utopianTree(int n) 
    {
        int h = 0;
        for (int i = 0; i <= n; i++)
        {
            if(i == 0)
            {
                h = 1;
            }
            else if(i % 2 != 0)
            {
                h = h * 2;
            }
            else if(i % 2 ==0)
            {
                h = h + 1;
            }
            else // when something went wrong I will know that I do not prepare right "if" statement
            {
                Console.WriteLine("Something go wrong..."); 
            }
        }
        return h;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
