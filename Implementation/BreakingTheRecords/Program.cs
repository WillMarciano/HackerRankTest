using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> BreakingRecords(List<int> scores)
    {
        int min = 0;
        int max = 0;
        int best = 0;
        int worst = 0;
        var result = new List<int>();

        for (int i = 0; i < scores.Count; i++)
        {
            if (i == 0)
            {
                min = scores[i];
                max = scores[i];
            }
            if (scores[i] < min)
            {
                min = scores[i];
                worst++;
            }
            if (scores[i] > max)
            {
                max = scores[i];
                best++;
            }
        }
        result.Add(best);
        result.Add(worst);

        return result;
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

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.BreakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
