using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 0) { Console.WriteLine("0"); return; }
        string base5 = "";
        while (n > 0)
        {
            base5 = (n % 5) + base5;
            n /= 5;
        }
        Console.WriteLine($"Представление в 5-чной СС: {base5}");
    }
}
