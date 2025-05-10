using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int n, attempts = 0;
        Console.Write("Сгенерированные числа: ");
        do
        {
            n = rnd.Next(1, 11); // от 1 до 10
            Console.Write(n + " ");
            attempts++;
        } while (n != 7);
        Console.WriteLine($"\nПопыток: {attempts}");
    }
}
