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

    // Complete the minimumNumber function below.
    static int minimumNumber(int n, string password)
    {
        string special_characters = "!@#$%^&*()-+";
        bool isSpecial = false;
        for (int i = 0; i < special_characters.Length; i++)
        {
            if (password.Contains(special_characters[i]))
            {
                isSpecial = true;
            }
        }        
        int result = 0;
        int different = 0;
        if (password.Length>=6)
        {
            if (password.Count(v => char.IsUpper(v)) == 0)
            {
                result++;
            }
            if (password.Count(v => char.IsLower(v)) == 0)
            {
                result++;
            }
            if (password.Count(v => char.IsDigit(v)) == 0)
            {
                result++;
            }
            if (!isSpecial)
            {
                result++;
            }
        }
        else
        {
            if (password.Count(v => char.IsUpper(v)) == 0)
            {
                different++;
            }
            if (password.Count(v => char.IsLower(v)) == 0)
            {
                different++;
            }
            if (password.Count(v => char.IsDigit(v)) == 0)
            {
                different++;
            }
            if (!isSpecial)
            {
                different++;
            }
            if (6-password.Length <= different)
            {
                result = different;
            }
            if (6 - password.Length > different)
            {
                result = 6 - password.Length;
            }
        }       
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
