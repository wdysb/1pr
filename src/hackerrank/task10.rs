// https://www.hackerrank.com/challenges/sock-merchant/problem
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

class Result
{

    public static int sockMerchant(int n, List<int> ar)
    {
        HashSet<int> socks = new HashSet<int>();
        int pairs = 0;

        for (int i = 0; i < ar.Count; i++)
        {
            if (socks.Contains(ar[i]))
            {
                socks.Remove(ar[i]);
                pairs++;
            }
            else
            {
                socks.Add(ar[i]);
            }
        }

        return pairs;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH") ?? "output.txt";
        TextWriter textWriter = new StreamWriter(outputPath, true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
