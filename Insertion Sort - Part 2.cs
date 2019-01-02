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

    // Complete the insertionSort2 function below.
    static void insertionSort2(int n, int[] arr)
    {
        for(int i=0; i < n-1 ; i++)
        {
            for(int j=0; j < n-1 ;j++)
            {
                int temp = arr[i+1];
                if(j==i+1)
                    break;           
                if(arr[j]>temp)
                {
                    arr[i+1]=arr[j];
                    arr[j]=temp;
                }
            }
            foreach(int item in arr)
            {
                Console.Write("{0} ", item);
            } 
            Console.Write("\n");
        }        
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        insertionSort2(n, arr);
    }
}
