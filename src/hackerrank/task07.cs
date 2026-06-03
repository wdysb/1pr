using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int lcm(int a, int b)
    {
        if (a == 0 || b == 0) return 0;
        return Math.Abs(a * b) / gcd(a, b);
    }

    public static int getTotalX(List<int> a, List<int> b)
    {
        int l = a[0];
        foreach (int i in a)
        {
            l = lcm(l, i);
        }

        int g = b[0];
        foreach (int i in b)
        {
            g = gcd(g, i);
        }

        int count = 0;
        for (int i = l, j = 1; i <= g; i = l * ++j)
        {
            if (g % i == 0)
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> brr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int result = getTotalX(arr, brr);
        Console.WriteLine(result);
    }
}
