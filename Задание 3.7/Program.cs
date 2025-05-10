using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное n: ");
        int n = int.Parse(Console.ReadLine());
        int square = 0;
        // 1 + 3 + 5 + … + (2n–1)
        for (int odd = 1, count = 0; count < n; odd += 2, count++)
            square += odd;
        Console.WriteLine($"{n}² = {square}");
    }
}
