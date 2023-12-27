using System;

class URI
{

    static void Main(string[] args)
    {

        int distancia = int.Parse(Console.ReadLine());

        int qtdMinutos = (60 * distancia) / 30;
        Console.WriteLine($"{qtdMinutos} minutos");

    }

}