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

    // Complete the decentNumber function below.
    static string decentNumber(int n)
    {
        int numberOfFivesInDecentNumber = n;
        int numberOfThreesInDecentNumber = 0;
        string _5 = "5";
        string _3 = "3";
        string result = "-1";
        /**
         * Check possibility for only 5s.
         */
        if (n % 3 == 0)
        {
            result = string.Concat(Enumerable.Repeat(_5, n));
            return result;
        }
        /**
         * Check possibility for 3s preceded by 5s.
         */
        numberOfFivesInDecentNumber -= 5;
        while (numberOfFivesInDecentNumber >= 0)
        {
            numberOfThreesInDecentNumber += 5;
            if (numberOfFivesInDecentNumber % 3 == 0)
            {
                result = string.Concat(Enumerable.Repeat(_5, numberOfFivesInDecentNumber)) + string.Concat(Enumerable.Repeat(_3, numberOfThreesInDecentNumber));                
                return result;
            }
            numberOfFivesInDecentNumber -= 5;
        }
        /**
         * Check possibility for only 3s.
         */
        if (n % 5 == 0)
        {
            numberOfFivesInDecentNumber = 0;
            numberOfThreesInDecentNumber = n;
            result = string.Concat(Enumerable.Repeat(_3, numberOfThreesInDecentNumber));
            return result;
        }
        return result;
    }
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim())

            Console.WriteLine(decentNumber(n));
        }
    }
}
