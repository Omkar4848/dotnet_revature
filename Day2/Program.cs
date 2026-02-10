using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int iterations = 100000;

        Stopwatch sw = new Stopwatch();
        sw.Start();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append(i);
        }

        string result = sb.ToString();

        sw.Stop();
        Console.WriteLine("Using StringBuilder: " + sw.ElapsedMilliseconds + " ms");
    }
}
