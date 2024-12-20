﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int BirthdayCakeCandles(List<int> candles) 
        => candles.Count(c => c == candles.Max());

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.BirthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
