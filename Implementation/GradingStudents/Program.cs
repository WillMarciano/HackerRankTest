using System.Collections.Generic;
using System.IO;
using System;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> GradingStudents(List<int> grades)
    {
        var result = new List<int>();

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38 && grades[i] % 5 >= 3)
                result.Add(grades[i] + (5 - grades[i] % 5));
            else
                result.Add(grades[i]);
        }
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

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.GradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
        Console.WriteLine();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
        Console.ReadKey();
    }
}