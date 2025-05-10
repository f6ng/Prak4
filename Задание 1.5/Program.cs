using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите двоичное число: ");
        int bin = int.Parse(Console.ReadLine());
        int result = 0;
        int power = 1;
        while (bin > 0)
        {
            result += (bin % 10) * power;
            bin /= 10;
            power *= 2;
        }
        Console.WriteLine($"Десятичное значение: {result}");
    }
}
