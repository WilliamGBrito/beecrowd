using System;

class URI
{

    static void Main(string[] args)
    {

        double raio = double.Parse(Console.ReadLine());

        double esfera = (4 / 3.0) * 3.14159 * (Math.Pow(raio, 3.0));

        Console.WriteLine($"VOLUME = {esfera:F3}");

    }

}