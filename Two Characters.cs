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

    // Complete the alternate function below.
    static int alternate(string s)
    {        
        int l = s.Length;
        int[] frequency = new int[28];
        int current = -1;
        int counter = 0;
        int result=0;
        char c1='\0', c2='\0';// two char at null
        for(int i = 0 ; i<l ; i++)
        {
            frequency[(int)s[i] - 96]++; // ASCII code            
        }
        //taking every possible pair(c1 , c2) from the given string
        for(int i = 1 ; i<27 ; i++)
        {
            if(frequency[i] != 0)
            {
                for(int j = i+1  ; j<=27 ; j++)
                {
                    if(frequency[j] != 0)
                    {
                         c1 = (char)(i+96);
                         c2 = (char)(j+96);
                    }
                    // if a pair alternates than finding the counter and comparing
                    // it with result to get the maximum counter in result
                    for(int z = 0 ; z<l ; z++)
                    {
                        if(s[z] == c1)
                        {
                            if(current == 1)
                            {
                                current = -1;
                                break;
                            }
                            current = 1;
                            counter++;
                        }
                        else if(s[z] == c2)
                        {
                            if(current == 2)
                            {
                                current = -1;
                                break;
                            }
                            current = 2;
                            counter++;
                        }
                    }
                    if( current!= -1 && counter > 1 && counter > result)
                    {
                        result = counter;                        
                    }
                    counter = 0;
                }
            }
        }
        return result;
    }
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int l = Convert.ToInt32(Console.ReadLine().Trim());
        string s = Console.ReadLine();
        int result = alternate(s);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
