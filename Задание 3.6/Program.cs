using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        double sum = 0;
        double xPow = x;
        for (int i = 1; i <= 11; i += 2)
        {
            sum += xPow / i;
            xPow *= x * x;
        }
        Console.WriteLine($"Результат = {sum}");
    }
}
