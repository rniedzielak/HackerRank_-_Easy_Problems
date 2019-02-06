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

class Solution 
{
    /* Finds the winner of the game. Returns true if "First" wins */
    private static bool isFirstPlayerWinner(int[] stones)
    {
        /* In a single pile, if more than one stones exist then first player will
        * always win by leaving the last stone for second player to pick up
        */
        if (stones.Length == 1)
        {
            return stones[0] > 1;
        }      
        int totalStones = stones[0];
        int xorValue = stones[0];
        
        for (int s = 1; s < stones.Length; s++)
        {
            totalStones += stones[s];
            xorValue ^= stones[s];
        }
        
        /* If sum of all stones equals the total piles, all piles have a single (1)
         * stone. For even number of piles, first player will always win.
         */
        if (totalStones == stones.Length)
        {
            return totalStones % 2 == 0;
        }
        
        /* For all other cases, the xor value determines winner. If xor value = 0,
         * then second player will always win as all piles (stones) can be paired. 
         */

        return xorValue > 0;    
    }

    // Complete the misereNim function below.
    static string misereNim(int[] s) 
    {
        if(isFirstPlayerWinner(s))
        {
            return "First";
        }      
        return "Second";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            string result = misereNim(s);
            textWriter.WriteLine(result);
        }
        textWriter.Flush();
        textWriter.Close();
    }
}
