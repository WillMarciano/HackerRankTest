using System.Collections.Generic;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void MiniMaxSum(List<int> arr)
    {
        arr.Sort();

        long minimum = arr.Take(4).Sum(x => (long)x);
        long maximum = arr.Skip(1).Sum(x => (long)x) ;

        Console.WriteLine($"{ minimum } { maximum }");
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.MiniMaxSum(arr);
    }
}