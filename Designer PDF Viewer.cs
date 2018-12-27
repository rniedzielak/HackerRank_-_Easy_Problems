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

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word)
    {
        List<int> h_bis = new List<int>(); //set alpha {a b c d e f g h i j 
        for (int i = 0; i<word.Length; i++) //k m n o p q r s t u v w x y z}
        {
            if(word[i]=='a')
            {
                h_bis.Add(h[0]);
            }
            if(word[i]=='b')
            {
                h_bis.Add(h[1]);
            }
            if(word[i]=='c')
            {
                h_bis.Add(h[2]);
            }
            if(word[i]=='d')
            {
                h_bis.Add(h[3]);
            }
            if(word[i]=='e')
            {
                h_bis.Add(h[4]);
            }
            if(word[i]=='f')
            {
                h_bis.Add(h[5]);
            }
            if(word[i]=='g')
            {
                h_bis.Add(h[6]);
            }
            if(word[i]=='h')
            {
                h_bis.Add(h[7]);
            }
            if(word[i]=='i')
            {
                h_bis.Add(h[8]);
            }
            if(word[i]=='j')
            {
                h_bis.Add(h[9]);
            }
            if(word[i]=='k')
            {
                h_bis.Add(h[10]);
            }
            if(word[i]=='l')
            {
                h_bis.Add(h[11]);
            }
            if(word[i]=='m')
            {
                h_bis.Add(h[12]);
            }
            if(word[i]=='n')
            {
                h_bis.Add(h[13]);
            }
            if(word[i]=='o')
            {
                h_bis.Add(h[14]);
            }
            if(word[i]=='p')
            {
                h_bis.Add(h[15]);
            }
            if(word[i]=='q')
            {
                h_bis.Add(h[16]);
            }
            if(word[i]=='r')
            {
                h_bis.Add(h[17]);
            }
            if(word[i]=='s')
            {
                h_bis.Add(h[18]);
            }
            if(word[i]=='t')
            {
                h_bis.Add(h[19]);
            }
            if(word[i]=='u')
            {
                h_bis.Add(h[20]);
            }
            if(word[i]=='v')
            {
                h_bis.Add(h[21]);
            }
            if(word[i]=='w')
            {
                h_bis.Add(h[22]);
            }
            if(word[i]=='x')
            {
                h_bis.Add(h[23]);
            }
            if(word[i]=='y')
            {
                h_bis.Add(h[24]);
            }
            if(word[i]=='z')
            {
                h_bis.Add(h[25]);
            }
        }
        int area = word.Length * h_bis.Max();
        return area;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
