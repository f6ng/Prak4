using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Сколько раз вывести: ");
        int times = int.Parse(Console.ReadLine());
        for (int i = 0; i < times; i++)
            Console.Write(value + " ");
    }
}
