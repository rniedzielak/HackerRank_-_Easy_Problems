using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
 static int getTotalX(int[] a, int[] b)
    {
        List<int> results = new List<int>();
        List<int> from_a = new List<int>();
        List<int> from_b = new List<int>();
        for (int i = 1; i < 101; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                if (i % a[j] == 0 && i <= b.Min())
                {
                    if (a.Length > 1)
                    {
                        if (a.Length < 3)
                        {
                            for (int k = 0; k < a.Length; k++)
                            {
                                if (j != k && i % a[k] == 0 && i % a[j] == 0 && !from_a.Contains(i))
                                {
                                    from_a.Add(i);
                                }
                            }
                        }
                        if (a.Length >= 3)
                        {
                            for (int k = 0; k < a.Length; k++)
                            {
                                for (int n = 0; n < a.Length; n++)
                                {
                                    if (j != k && n!=j && n!= k && i % a[k] == 0 && i % a[j] == 0 && i % a[n] == 0 && !from_a.Contains(i))
                                    {
                                        from_a.Add(i);
                                    }
                                }
                               
                            }
                        }
                        
                    }
                    else if (a.Length ==1)
                    {
                        if (i % a[j] == 0 && i <= b.Min() && !from_a.Contains(i))
                        {
                            from_a.Add(i);
                        }
                    }
                    
                }
            }
        }
        for (int i = 1; i < 101; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (b.Length > 1 && b.Length < 3 && b[j] % i == 0 && i >= a.Max())
                {
                    for (int k = 0; k < b.Length; k++)
                    {
                        if (j != k && b[k] % i == 0 && b[j] % i == 0 && !from_b.Contains(i))
                        {
                            from_b.Add(i);
                        }
                    }
                }
                else if (b.Length == 1)
                {
                    if (b[j] % i == 0 && i >= a.Max() && !from_b.Contains(i))
                    {
                        from_b.Add(i);
                    }

                }
                else if (b.Length >= 3)
                {
                    for (int k = 0; k < b.Length; k++)
                    {
                        for (int n = 0; n < b.Length; n++)
                        {
                            if (j != k && n!= k && n!= j && b[k] % i == 0 && b[j] % i == 0 && b[n]%i ==0 && !from_b.Contains(i))
                            {
                                from_b.Add(i);
                            }
                        }
                       
                    }
                }
            }
        }
        for (int i = 0; i < from_b.Count; i++)
        {
            if (from_a.Contains(from_b[i]) && !results.Contains(from_b[i]) && a.Max() <= from_b[i] && b.Min() >= from_b[i])                
            {
                results.Add(from_b[i]);
            }
        }
        return results.Count;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
