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

class Solution
{
    // Complete the stones function below.
    static int[] stones(int n, int a, int b)
    {
        int[] arrStones=new int[n];
        for(int i = 0; i < n;i++)
        {
            int temp=a*((n-1)-i)+b*i;
            arrStones[i]=temp;
        }
        Array.Sort(arrStones);
        return arrStones;
    }
    static void Main(string[] args) 
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr < T; TItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            int[] result = stones(n, a, b);
            if(result[0]==result[result.Length-1])
            {
                textWriter.Write(result[0]);
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    textWriter.Write(result[i]);

                    if (i != result.Length - 1)
                    {
                        textWriter.Write(" ");
                    }
                }
            } 
            textWriter.WriteLine("");           
        }
        textWriter.Flush();
        textWriter.Close();
    }    
}
