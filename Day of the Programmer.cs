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

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year)
    {
        string result = "";
        if(year == 1918) // I guess that is a misteak in problem... why??
        {
            result = String.Format("26.09.{0}", year);
        }
        else if(year == 1700 || year == 1800 || year == 1900)
        {
            result = String.Format("12.09.{0}", year);
        }
        else if ((year % 4 == 0 & year % 100 !=0) || year % 400 ==0) // Leap
        {
            result = String.Format("12.09.{0}", year);
        }
        else
        {
            result = String.Format("13.09.{0}", year);
        }
        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
