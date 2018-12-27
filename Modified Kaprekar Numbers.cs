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

    // Complete the kaprekarNumbers function below.
    static void kaprekarNumbers(int p, int q)
    {       
        int counter=0;
        long square = 0; 
        string number="";
        long isKaprekar=0;
        for(long i=(long)p; i<=(long)q; i++)
        {
            square = i*i;
            number = square.ToString();
            if(i==1)
            {
                Console.Write("{0} ",i);
                counter++;
            }
            else if(number.Length%2==0)
            {
                isKaprekar=Convert.ToInt64(number.Substring(0,number.Length/2))+Convert.ToInt64(number.Substring(number.Length/2));
                if(isKaprekar==i)
                {
                    Console.Write("{0} ",i);
                    counter++;
                }
            }
            else if(number.Length%2!=0 && i>3)
            {
                isKaprekar=Convert.ToInt64(number.Substring(0,(int)Math.Floor((double)number.Length/2)))+Convert.ToInt64(number.Substring((int)Math.Floor((double)number.Length/2)));
                if(isKaprekar==i)
                {
                    Console.Write("{0} ",i);
                    counter++;
                }
            }
        }
        if(counter==0)
        {
            Console.WriteLine("INVALID RANGE");
        }
    }

    static void Main(string[] args) {
        int p = Convert.ToInt32(Console.ReadLine());

        int q = Convert.ToInt32(Console.ReadLine());

        kaprekarNumbers(p, q);
    }
}
