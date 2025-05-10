using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n (1 < n ≤ 10): ");
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;    // i!
            sum += factorial;  // накопление
        }
        Console.WriteLine($"Сумма 1!+…+{n}! = {sum}");
    }
}
