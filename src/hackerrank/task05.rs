using System;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (int apple in apples)
        {
            int position = a + apple;
            if (position >= s && position <= t)
            {
                appleCount++;
            }
        }

        foreach (int orange in oranges)
        {
            int position = b + orange;
            if (position >= s && position <= t)
            {
                orangeCount++;
            }
        }

        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }

    static void Main(string[] args)
    {
        string[] st = Console.ReadLine().Split(' ');
        int s = int.Parse(st[0]);
        int t = int.Parse(st[1]);

        string[] ab = Console.ReadLine().Split(' ');
        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
