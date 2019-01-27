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

    // Complete the gridChallenge function below.
    static string gridChallenge(string[] grid)
    {
        char[][] gridChar = new char[grid.Length][];            
        for (int i = 0; i < grid.Length; i++)
        {
            gridChar[i] = grid[i].ToCharArray();
            Array.Sort(gridChar[i]);
        }
        char[][] gridChar2 = new char[gridChar[0].Length][];
        for (int i = 0; i < gridChar[0].Length; i++)
        {
            gridChar2[i] = new char[grid.Length];
            for (int j = 0; j < grid.Length; j++)
            {
                gridChar2[i][j] = gridChar[j][i];
            }
        }
        for (int i = 0; i < gridChar2.Length; i++)
        {
            char[] temp = new char[gridChar2[i].Length];
            for (int j = 0; j < gridChar2[i].Length; j++)
            {
                temp[j] = gridChar2[i][j];
            }
            Array.Sort(temp);
            for (int j = 0; j < gridChar2[i].Length; j++)
                if (temp[j] != gridChar2[i][j])
                    return "NO";
        }
        return "YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] grid = new string [n];

            for (int i = 0; i < n; i++) {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            string result = gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
