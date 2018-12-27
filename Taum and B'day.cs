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

    // Complete the taumBday function below.
    static long taumBday(long b, long w, long bc, long wc, long z)
    {
        if (wc + z < bc) bc = wc + z;

        if (bc + z < wc) wc = bc + z;

        return (b * bc) + (w * wc);

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] bw = Console.ReadLine().Split(' ');

            long b = Convert.ToInt64(bw[0]);

            long w = Convert.ToInt64(bw[1]);

            string[] bcWcz = Console.ReadLine().Split(' ');

            long bc = Convert.ToInt64(bcWcz[0]);

            long wc = Convert.ToInt64(bcWcz[1]);

            long z = Convert.ToInt64(bcWcz[2]);

            long result = taumBday(b, w, bc, wc, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
