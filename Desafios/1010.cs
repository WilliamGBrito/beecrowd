using System;

class URI
{

    static void Main(string[] args)
    {

        string[] prod1 = Console.ReadLine().Split(' ');
        int num1 = int.Parse(prod1[1]);
        double val1 = double.Parse(prod1[2]);

        string[] prod2 = Console.ReadLine().Split(' ');
        int num2 = int.Parse(prod2[1]);
        double val2 = double.Parse(prod2[2]);

        double total = num1 * val1 + num2 * val2;
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

    }

}