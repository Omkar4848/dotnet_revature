using System;

public class ControlFlowDemo
{
    public static void Run()
    {
        Console.WriteLine("\n--- Control Flow ---");

        int num = 5;

        if (num > 0)
            Console.WriteLine("Positive");

        // For Loop
        for (int i = 1; i <= 3; i++)
            Console.WriteLine("For: " + i);

        // While Loop
        int j = 1;
        while (j <= 3)
        {
            Console.WriteLine("While: " + j);
            j++;
        }
    }
}
