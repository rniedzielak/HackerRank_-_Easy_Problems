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

    // Complete the saveThePrisoner function below.
    static int saveThePrisoner(int n, int m, int s)
    {
        //int result = 0;
        //int j = 0;
        //while(j < m)
        //{
        //    if(j == 0)
        //    {
        //        for(int i = s; i <= n; i++)
        //        {
        //            if(j < m)
        //            {
        //                result = i;
        //            }                    
        //            j++;
        //            if(j >= m)
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for(int i = 1; i <= n; i++)
        //        {
        //            if(j < m)
        //            {
        //                result = i;
        //            }
        //            j++;
        //            if(j >= m)
        //            {
        //                break;
        //            }
        //
        //        }
        //    }            
        // }
        //return result;
        // This is mathematis riddle <--- it is needed to solve this by single equation.
        // 
        // WHY??
        //int result = ((m+s)%n) - 1;
        //if(result == 0)
        //{
        //    return n;
        //}
        //else if(result ==-1)
        //{
        //    return n-1;
        //}
        //else
        //{
        //    return result;
        //} 
        return (s + m - 2) % n + 1;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nms = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nms[0]);

            int m = Convert.ToInt32(nms[1]);

            int s = Convert.ToInt32(nms[2]);

            int result = saveThePrisoner(n, m, s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
