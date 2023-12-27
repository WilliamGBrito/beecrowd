using System;

class URI
{

    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        double consumoMedio = X / Y;

        Console.WriteLine($"{consumoMedio:F3} km/l");

    }

}