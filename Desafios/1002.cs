using System;

class URI
{

    static void Main(string[] args)
    {
        double PI = 3.14159;
        double raio = Math.Round(double.Parse(Console.ReadLine()), 2);
        Console.WriteLine($"A={PI * Math.Pow(raio, 2):F4}");
    }

}