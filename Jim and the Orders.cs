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

    // Complete the jimOrders function below.
    static int[] jimOrders(int[][] orders)
    {
        Dictionary<int, int> helpingArray = new Dictionary<int, int>();
        for(int i = 0; i<orders.Length; i++)
        {
            helpingArray.Add(i + 1, orders[i][0]+orders[i][1]);
        }
        List<int> result = new List<int>();
        var sortedDict = from entry in helpingArray orderby entry.Value ascending select entry;
        foreach(KeyValuePair<int, int> kvp in sortedDict)
        {
            result.Add(kvp.Key);
        }
        return result.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] orders = new int[n][];
        for (int i = 0; i < n; i++)
        {
            orders[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
        }
        int[] result = jimOrders(orders);
        textWriter.WriteLine(string.Join(" ", result));
        textWriter.Flush();
        textWriter.Close();
    }
}
