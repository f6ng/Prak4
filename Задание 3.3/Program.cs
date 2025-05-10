using System;

class Program
{
    static void Main()
    {
        // (a) от 20 до 35
        for (int i = 20; i <= 35; i++)
            Console.WriteLine(i);

        // (б) квадраты от 10 до b (b>10)
        Console.Write("Введите b (>10): ");
        int b = int.Parse(Console.ReadLine());
        for (int i = 10; i <= b; i++)
            Console.WriteLine($"{i}² = {i * i}");

        // (в) кубы от a до 50 (a<50)
        Console.Write("Введите a (<50): ");
        int a = int.Parse(Console.ReadLine());
        for (int i = a; i <= 50; i++)
            Console.WriteLine($"{i}³ = {i * i * i}");

        // (г) от a до b (b<a) — в убывающем порядке
        Console.Write("Введите a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите b (<a): ");
        b = int.Parse(Console.ReadLine());
        for (int i = a; i >= b; i--)
            Console.WriteLine(i);
    }
}
