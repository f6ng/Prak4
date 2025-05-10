using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число в 7-чной системе: ");
        int sept = int.Parse(Console.ReadLine());
        int result = 0;
        int power = 1;
        while (sept > 0)
        {
            result += (sept % 10) * power;
            sept /= 10;
            power *= 7;
        }
        Console.WriteLine($"Десятичное значение: {result}");
    }
}
