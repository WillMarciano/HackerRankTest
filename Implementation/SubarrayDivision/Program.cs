﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int Birthday(List<int> s, int d, int m)
    {
        int sum = 0, count = 0;

        for (int i = 0; i < s.Count; i++)
        {
            sum += s[i];

            if (i >= m) sum -= s[i - m];
            if (sum == d && i >= m - 1) count++; ;
        }

        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output.txt");
        TextWriter textWriter = new StreamWriter(outputPath, true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.Birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
