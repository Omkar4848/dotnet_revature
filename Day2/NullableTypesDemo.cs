using System;

public class NullableTypesDemo
{
  public static void Run()
  {
    Console.WriteLine("\n--- Nullable Types ---");

    int? number = null;

    if (number.HasValue)
      Console.WriteLine(number.Value);
    else
      Console.WriteLine("Value is null");
  }
}
