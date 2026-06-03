// https://www.hackerrank.com/challenges/migratory-birds/problem
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

    public static int migratoryBirds(List<int> arr)
    {
        int[] counts = new int[6];
        
        foreach (int bird in arr)
        {
            counts[bird]++;
        }
        
        int maxCount = 0;
        int maxId = 0;
        
        for (int i = 1; i <= 5; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                maxId = i;
            }
        }
        
        return maxId;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

