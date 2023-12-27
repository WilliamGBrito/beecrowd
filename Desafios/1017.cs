using System;

class URI
{

    static void Main(string[] args)
    {

        int qtdHoras = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());

        double qtdLitros = (qtdHoras * velocidadeMedia) / 12.0;

        Console.WriteLine($"{qtdLitros:F3}");

    }

}