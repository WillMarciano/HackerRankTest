using System.Collections.Generic;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void PlusMinus(List<int> arr)
    {
        int plus = 0;
        int minus = 0;
        int zero = 0;
        int cont = arr.Count();

        for (int i = 0; i < cont; i++)
        {
            if (arr[i] == 0)
                zero++;
            else if (arr[i] > 0)
                plus++;
            else
                minus++;
        }

        Console.WriteLine(ReturnFrac((double)plus / cont));
        Console.WriteLine(ReturnFrac((double)minus / cont));
        Console.WriteLine(ReturnFrac((double)zero / cont));
    }

    private static string ReturnFrac(double result) => result.ToString("F6");

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.PlusMinus(arr);
    }
}