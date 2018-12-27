using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        return ar.GroupBy( x => x ).Select( x => (x.Count() - (x.Count() % 2)) / 2).Sum();
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
