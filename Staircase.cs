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

    // Complete the staircase function below.
    static void staircase(int n)
    {
        string text = "#";
        string text1 = " ";
        for(int i = 0; i < n; i++)
        {
            int x = n - i - 1;
            int y = 0;
            int z = 0;            
            while(y < x)
            {
                Console.Write(text1);
                y++;
            }
            while(z <= i)
            {
                Console.Write(text);
                z++;
            }
            Console.Write(String.Format("\n"));
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
