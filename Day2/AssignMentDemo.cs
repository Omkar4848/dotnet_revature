using System;
using System.Diagnostics;
using System.Text;

public class StopwatchProgram
{
  public static void Run()
  {
    Console.WriteLine("\n--- Stopwatch Demo ---");

    Stopwatch sw = new Stopwatch();
    sw.Start();

    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < 10000; i++)
    {
      sb.Append(i);
    }

    sw.Stop();
    Console.WriteLine("Time: " + sw.ElapsedMilliseconds + " ms");
  }
}
