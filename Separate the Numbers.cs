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

    // Complete the separateNumbers function below.
    static void separateNumbers(string s)
    {
        if(s.Length == 1 || s[0] == '0')
        {
            Console.WriteLine("NO");
            return;
        }
        long temp0 = 0;
        bool test = false;    
        char[] arr = s.ToCharArray();        
        for(int i=1; i <= arr.Length/2 ; i++)
        {
            string first = s.Substring(0,i);
            long temp1 = Convert.ToInt64(first);
            temp0 = temp1;
            string k = temp0.ToString();
            while (k.Length < s.Length)
            {
                k += (++temp1).ToString();
            }
            if (k.Equals(s))
            {
                test = true;
                break;
            }
        }
        
        if(test == true)
            Console.WriteLine("YES "+temp0);
        else
            Console.WriteLine("NO");        
    }   

    static void Main(string[] args) {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            separateNumbers(s);
        }
    }
}
