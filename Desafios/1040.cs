using System;

class URI
{

    static void Main(string[] args)
    {

        string[] notas = Console.ReadLine().Split(' ');
        double n1 = double.Parse(notas[0]);
        double n2 = double.Parse(notas[1]);
        double n3 = double.Parse(notas[2]);
        double n4 = double.Parse(notas[3]);

        var media = Math.Floor((2.0 * n1) + (3.0 * n2) + (4.0 * n3) + (1.0 * n4)) / 10;

        if (media >= 7.0)
        {
            Console.WriteLine($"Media: {media:F1}");
            Console.WriteLine($"Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine($"Media: {media:F1}");
            Console.WriteLine($"Aluno reprovado.");
        }
        else
        {
            Console.WriteLine($"Media: {media:F1}");
            Console.WriteLine($"Aluno em exame.");

            double exame = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {exame:F1}");

            double mediaFinal = (media + exame) / 2.0;

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {mediaFinal:F1}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {mediaFinal:F1}");
            }
        }

    }

}