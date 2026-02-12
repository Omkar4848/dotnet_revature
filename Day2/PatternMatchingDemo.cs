using System;

public class PatternMatchingDemo
{
  public static void Run()
  {
    Console.WriteLine("\n--- Pattern Matching ---");

    object obj = 10;

    if (obj is int number)
      Console.WriteLine("It is int: " + number);
  }
}
