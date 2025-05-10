using System;

class Program
{
    static void Main()
    {
        int num;
        do
        {
            Console.Write("Введите число от 1 до 100: ");
            num = int.Parse(Console.ReadLine());
        } while (num < 1 || num > 100);
        Console.WriteLine($"Введено: {num}");
    }
}
