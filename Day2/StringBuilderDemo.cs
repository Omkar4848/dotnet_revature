using System;
using System.Text;

public class StringBuilderDemo
{
  public static void Run()
  {
    Console.WriteLine("\n--- StringBuilder Demo ---");

    StringBuilder sb = new StringBuilder("Omkar");
    sb.Append(" Developer");

    Console.WriteLine(sb.ToString());
  }
}
