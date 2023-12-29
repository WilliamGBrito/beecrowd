using System;

class URI
{

    static void Main(string[] args)
    {

        int qtdDias = int.Parse(Console.ReadLine());

        int ano = qtdDias / 365;
        qtdDias = qtdDias % 365;

        int mes = qtdDias / 30;
        qtdDias = qtdDias % 30;

        int dia = qtdDias;

        Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dia} dia(s)");

    }

}