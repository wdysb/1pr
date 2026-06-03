using System;

class Solution
{
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 > v2 && (x2 - x1) % (v1 - v2) == 0)
        {
            return "YES";
        }
        return "NO";
    }

    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        if (string.IsNullOrEmpty(inputLine)) return;

        string[] input = inputLine.Split(' ');
        
        int x1 = int.Parse(input[0]);
        int v1 = int.Parse(input[1]);
        int x2 = int.Parse(input[2]);
        int v2 = int.Parse(input[3]);

        Console.WriteLine(kangaroo(x1, v1, x2, v2));
    }
}
