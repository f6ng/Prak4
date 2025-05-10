using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите M: ");
        int M = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.Write($"{a} {b} ");
        while (true)
        {
            int c = a + b;
            if (c > M) break;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}
