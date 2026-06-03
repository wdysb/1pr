using System;

class Solution
{
    public static void Staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string spaces = new string(' ', n - i);
            string hashes = new string('#', i);
            Console.WriteLine(spaces + hashes);
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Staircase(n);
    }
}
// https://www.hackerrank.com/challenges/staircase/problem
