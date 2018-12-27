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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int counter_of_worst = 0;
        int counter_of_record = 0;
        int index_of_record = 0;
        int index_of_worst = 0;
        int broke_record = scores[index_of_record];
        int broke_worst = scores[index_of_worst];
        for(int i = 0; i < scores.Length; i++)
        {
            if(scores[i]>broke_record)
            {
                broke_record=scores[i];
                counter_of_record++;
            }
            else if (scores[i]<broke_worst)
            {
                broke_worst=scores[i];
                counter_of_worst++;
            }
            else
                continue;
        }
        int[] result = new int[2];
        result[0] = counter_of_record;
        result[1] = counter_of_worst;
        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
