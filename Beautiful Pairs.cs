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
    // Complete the beautifulPairs function below.
    static int beautifulPairs(int[] A, int[] B)
    {
        HashSet<int> fromA = new HashSet<int>();
        HashSet<int> fromB = new HashSet<int>();
        int count = 0;        
        for(int i = 0; i<A.Length;i++)
        {
            for(int j = 0; j<B.Length; j++)
            {
                if(A[i]==B[j] &&((!fromA.Contains(i)) && (!fromB.Contains(j))))
                {
                    fromA.Add(i);
                    fromB.Add(j);
                    count++;
                }
            }
        }
        return count < A.Length ? count+1 : count-1;
    }
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));
        int result = beautifulPairs(A, B);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
