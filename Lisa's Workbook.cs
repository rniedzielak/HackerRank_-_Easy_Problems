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

    // Complete the workbook function below.
    static int workbook(int n, int k, int[] arr)
    {
        int counter = 0;
        int page = 0;
        for(int i = 0; i<n; i++)
        {
            if (i==0 || (i!=0 && arr[i-1]%k!=0))
            {
                page++;
            }
            for(int j = 1; j<=arr[i]; j++)
            {
                if(page == j)
                {
                    counter++;
                }
                if(j%k==0)
                {
                    page++;
                }
            }
        }
        return counter;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
