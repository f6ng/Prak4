using System;

class Program
{
    static void Main()
    {
        // (а)
        for (int i = 10; i <= 25; i++)
            Console.WriteLine($"{i} {i + 0.4}");

        // (б)
        for (int i = 25; i <= 35; i++)
            Console.WriteLine($"{i} {i + 0.5} {i - 0.2}");
    }
}
