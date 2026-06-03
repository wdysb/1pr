using System;
using System.Collections.Generic;

class Solution
{
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();

        foreach (int grade in grades)
        {
            if (grade >= 38)
            {
                int nextMultipleOf5 = ((grade / 5) + 1) * 5;
                if (nextMultipleOf5 - grade < 3)
                {
                    result.Add(nextMultipleOf5);
                    continue;
                }
            }
            result.Add(grade);
        }

        return result;
    }

    static void Main(string[] args)
    {
        if (!int.TryParse(Console.ReadLine(), out int n)) return;

        List<int> grades = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                grades.Add(grade);
            }
        }

        List<int> result = gradingStudents(grades);
        Console.WriteLine(string.Join("\n", result));
    }
}
