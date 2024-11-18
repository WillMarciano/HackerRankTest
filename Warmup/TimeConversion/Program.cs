using System.IO;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string TimeConversion(string s) => Convert.ToDateTime(s).ToString("HH:mm:ss");

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output.txt");
        TextWriter textWriter = new StreamWriter(outputPath, true);

        string s = Console.ReadLine();

        string result = Result.TimeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();

        //Console.WriteLine(result);
        //Console.ReadKey();
    }
}
