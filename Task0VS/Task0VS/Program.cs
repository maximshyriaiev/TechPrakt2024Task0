using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        Console.WriteLine($"Сума чисел: {sum}");
    }
}
