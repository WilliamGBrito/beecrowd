using System;

class URI
{

    static void Main(string[] args)
    {

        int qtdSegundos = int.Parse(Console.ReadLine());

        int horas = qtdSegundos / 3600;
        qtdSegundos = qtdSegundos % 3600;

        int minutos = qtdSegundos / 60;
        qtdSegundos = qtdSegundos % 60;

        int segundos = qtdSegundos;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");

    }

}