﻿using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
            sum += i * i;
        Console.WriteLine($"1²+2²+…+10² = {sum}");
    }
}
