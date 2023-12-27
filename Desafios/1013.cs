using System;

class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);
        int c = int.Parse(values[2]);

        int maior = a > b && a > c ? a : b > c ? b : c;

        Console.WriteLine($"{maior} eh o maior");

    }

}