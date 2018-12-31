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

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] unsorted = new string[n];
        for(int unsorted_i = 0; unsorted_i < n; unsorted_i++){
           unsorted[unsorted_i] = Console.ReadLine();   
        }
        Array.Sort(unsorted,(string a,string b) => {
            if(a.Length == b.Length)
                return string.Compare(a,b,StringComparison.Ordinal);
            return a.Length - b.Length;
        });
        Console.WriteLine(string.Join("\n",unsorted));
    }
}
// I have previously used brutal force sorting but I got timeout cases so using StrigComparison.Ordinal
// was better idea and I miss all part with solution method :) BRUTAL FORCE BELOW:
/* 
    // Complete the bigSorting function below.
    static string[] bigSorting(string[] unsorted) 
    {
        for(int i=0 ; i< unsorted.Length-1;i++)
        {
            for(int j =0 ;j< unsorted.Length-1-i;j++)
            {
                if(unsorted[j].Length > unsorted[j+1].Length)
                {
                    string temp = unsorted[j];
                    unsorted[j] = unsorted[j+1];
                    unsorted[j+1]= temp;
                    continue;
                }
                if(unsorted[j].Length == unsorted[j+1].Length)
                {
                    int count = 0;
                    while(count < unsorted[j].Length)
                    {
                        if(unsorted[j][count]!=unsorted[j+1][count])
                        {
                            if(unsorted[j][count]>unsorted[j+1][count])
                            {
                                String temp = unsorted[j];
                                unsorted[j]= unsorted[j+1];
                                unsorted[j+1]= temp;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        count++;
                    }
                    continue;
                }
            }
        }
        return unsorted;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] unsorted = new string [n];

        for (int i = 0; i < n; i++) {
            string unsortedItem = Console.ReadLine();
            unsorted[i] = unsortedItem;
        }

        string[] result = bigSorting(unsorted);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
} */
