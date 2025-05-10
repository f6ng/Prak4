using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 0) { Console.WriteLine("0"); return; }
        string bin = "";
        while (n > 0)
        {
            bin = (n % 2) + bin;
            n /= 2;
        }
        Console.WriteLine($"Двоичное представление: {bin}");
    }
}
