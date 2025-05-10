using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += sign * (1.0 / i);
            sign = -sign;
        }
        Console.WriteLine($"Результат = {sum}");
    }
}
