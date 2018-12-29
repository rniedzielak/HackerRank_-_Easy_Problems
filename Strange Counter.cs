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

    // Complete the strangeCounter function below.
    static long strangeCounter(long t)
    {//I will use the nomenclature in mathematics of geometric series:
        long sequence = (long)Math.Ceiling(Math.Log((double)t / 3 + 1, 2));
        /*   a logarithm with base = 2 from (t + 3) / 1 will give us part of
        present sequence of the geometric sequence with q = 2  */
        double q_n1 = Math.Pow(2, sequence - 1);
        // now we get q to the boundary "a" -->a(n) = q^(n-1)*a(1)
        long an = (long)q_n1 * 3;
        long goBack = t - (3 * ((long)q_n1 - 1)); /* t if be sum of sequence
                                                    then always answear be 1*/
        return an - (goBack - 1);


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long t = Convert.ToInt64(Console.ReadLine());

        long result = strangeCounter(t);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
