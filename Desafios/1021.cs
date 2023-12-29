using System;

class URI
{

    static void Main(string[] args)
    {

        double valorMonetario = double.Parse(Console.ReadLine());
        int valor = 0;

        Console.WriteLine($"NOTAS:");
        valor = (int)valorMonetario / 100;
        Console.WriteLine($"{valor} nota(s) de R$ 100.00");
        valorMonetario = valorMonetario % 100.0;

        valor = (int)valorMonetario / 50;
        Console.WriteLine($"{valor} nota(s) de R$ 50.00");
        valorMonetario = valorMonetario % 50.00;

        valor = (int)valorMonetario / 20;
        Console.WriteLine($"{valor} nota(s) de R$ 20.00");
        valorMonetario = valorMonetario % 20.00;

        valor = (int)valorMonetario / 10;
        Console.WriteLine($"{valor} nota(s) de R$ 10.00");
        valorMonetario = valorMonetario % 10.00;

        valor = (int)valorMonetario / 5;
        Console.WriteLine($"{valor} nota(s) de R$ 5.00");
        valorMonetario = valorMonetario % 5.00;

        valor = (int)valorMonetario / 2;
        Console.WriteLine($"{valor} nota(s) de R$ 2.00");
        valorMonetario = valorMonetario % 2.00;

        valorMonetario = valorMonetario * 100.0;

        Console.WriteLine($"MOEDAS:");

        valor = (int)valorMonetario / 100;
        Console.WriteLine($"{valor} moeda(s) de R$ 1.00");
        valorMonetario = valorMonetario % 100.0;

        valor = (int)valorMonetario / 50;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.50");
        valorMonetario = valorMonetario % 50.0;

        valor = (int)valorMonetario / 25;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.25");
        valorMonetario = valorMonetario % 25.0;

        valor = (int)valorMonetario / 10;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.10");
        valorMonetario = valorMonetario % 10.0;

        valor = (int)valorMonetario / 5;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.05");
        valorMonetario = valorMonetario % 5.0;

        valor = (int)valorMonetario / 1;
        Console.WriteLine($"{valor} moeda(s) de R$ 0.01");

    }

}