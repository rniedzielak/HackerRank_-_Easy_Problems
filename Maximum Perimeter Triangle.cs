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

    // Complete the maximumPerimeterTriangle function below.
    static int[] maximumPerimeterTriangle(int[] sticks) 
    {
        int[] result = { 0, 0, 0};
        if (Array.TrueForAll(sticks, v=> v==sticks[0])) // If it possible to create only equilateral_triangle
        {
            int [] equilateral_triangle = { sticks[0], sticks[0], sticks[0]};
            return equilateral_triangle;
        }
        Array.Sort(sticks);
        Array.Reverse(sticks);
        for (int i = 0; i < sticks.Length-2; i++)
        {
            if (result.Sum()< (sticks[i]+sticks[i+1]+sticks[i+2]) && sticks[i+2] + sticks[i+1] > sticks[i])
            {
                result[0] = sticks[i];
                result[1] = sticks[i + 1];
                result[2] = sticks[i + 2];
            }
        }
        if(result.Sum() == 0)
        {
            int[] error = new int[1];
            error[0] = -1;
            return error;
        }
        else
        {
            Array.Sort(result);
            return result;
        }
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] sticks = Array.ConvertAll(Console.ReadLine().Split(' '), sticksTemp => Convert.ToInt32(sticksTemp))
        ;
        int[] result = maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
