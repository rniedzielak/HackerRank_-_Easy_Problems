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
    // Complete the sumXor function below.
    static long sumXor(long n)
    {
        if(n==0)
            return 1;
        else
        {
            string binary = Convert.ToString(n, 2);
            int numOfZeros = binary.Count(v=> v=='0');
            return (long)Math.Pow(2, numOfZeros);
            // Number which is result is 2^(number of zeroes) where number of zeroes come from binary from of number
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        long n = Convert.ToInt64(Console.ReadLine().Trim());
        long result = sumXor(n);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
