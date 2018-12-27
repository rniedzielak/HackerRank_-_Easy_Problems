using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades) 
    {
        int [] result = new int [grades.Length];

        for(int i = 0; i < grades.Length; i++)
        {
            int a = grades[i];
            int b = (a / 5 + 1)*5;
            int c = b - a;
            if(a < 38)
            {
                result[i] = a;
            }
            else if(c < 3 && a >=38)
            {
                result[i] = b;
            }
            else
            {
                result[i] = a;
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
