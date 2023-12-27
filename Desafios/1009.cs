using System;

class URI
{

    static void Main(string[] args)
    {

        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double salesAmount = double.Parse(Console.ReadLine());

        double total = 15.0 / 100.0 * salesAmount + salary;

        Console.WriteLine($"TOTAL = R$ {total:F2}");

    }

}