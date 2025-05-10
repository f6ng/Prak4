using System;

class Program
{
    static void Main()
    {
        int sum = 0, num;
        Console.WriteLine("Введите числа (0 — для завершения):");
        do
        {
            num = int.Parse(Console.ReadLine());
            sum += num;
        } while (num != 0);
        Console.WriteLine($"Сумма = {sum}");
    }
}
