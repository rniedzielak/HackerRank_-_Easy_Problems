using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) 
    {
        /*
         * Write your code here.
         */
        List<int> turns = new List<int>();
        if(p % 2 == 0)
        {
            turns.Add(p/2);
            
            if(n % 2==0)
            {
                turns.Add((n-p)/2);
            }
            else
            {
                turns.Add(((n-1)-p)/2);
            }
        }
        else
        {
            turns.Add((p-1)/2);
            
            if(n % 2==0)
            {
                turns.Add(((n+1)-p)/2);
            }
            else
            {
                turns.Add((n-p)/2);
            }
        }
        int min = turns.Min();
        return min;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
