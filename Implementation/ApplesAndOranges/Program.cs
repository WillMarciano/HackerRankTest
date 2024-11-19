using System.Collections.Generic;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int apple = 0;
        int orange = 0;

        for (int i = 0; i < apples.Count; i++)
        {
            if (a + apples[i] >= s && a + apples[i] <= t)
                apple++;
        }

        for (int i = 0; i < oranges.Count; i++)
        {
            if (b + oranges[i] >= s && b + oranges[i] <= t)
                orange++;
        }

        Console.WriteLine(apple);
        Console.WriteLine(orange);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.CountApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
