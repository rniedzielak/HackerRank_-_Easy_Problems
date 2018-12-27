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

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

public static int pickingNumbers(List<int> a)
    {
        int result = 0;
        List<int> subarray1 = new List<int>();
       
        List<int> subarray3 = new List<int>();
        a.Sort();
        for (int j = 0; j < a.Count; j++)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (subarray1.Count == 0 && i == j)
                {
                    subarray1.Add(a[i]);
                }
                else if (subarray1.Count == 0 && i!=j)
                {
                    subarray1.Add(a[j]);
                }
                else if (i != j && a[i] == subarray1.Min() || a[i] == subarray1.Min() + 1)
                {
                    subarray1.Add(a[i]);
                } 
            }
            if (subarray3.Count < subarray1.Count)
            {
                subarray3.Clear();                                
                foreach (var item in subarray1)
                {
                        subarray3.Add(item);
                }                
                subarray1.Clear();
            }
            else
            {
                subarray1.Clear();
            }
            result = subarray3.Count;            
        }
        return result;
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
