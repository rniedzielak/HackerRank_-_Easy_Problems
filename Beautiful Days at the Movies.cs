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

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k) 
    {
        int counter_of_days = 0;
        for(int n = i; n <= j; n++)
        {
            string temporary_string = Convert.ToString(n);
            string reversed_temporary_string = new string(temporary_string.Reverse().ToArray());
            int temp = Convert.ToInt32(reversed_temporary_string);
            if((n-temp)%k ==0)
            {
                counter_of_days++;
            }
            else if((n-temp)%k !=0)
            {
                continue;
            }
            else
            {
                Console.WriteLine("Something go wrong...");
            }
        } 
        return counter_of_days;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] ijk = Console.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);

        int j = Convert.ToInt32(ijk[1]);

        int k = Convert.ToInt32(ijk[2]);

        int result = beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
