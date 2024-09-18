using System;

class Program
{
    static void Main(string[] args)
    {
        int nota1, nota2,nota3;
        const int MinNota = 6;

        Console.WriteLine("Introdueix la primera qualificació");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la segona qualificació: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la tercera qualificació: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        float promig = (nota1 + nota2 + nota3) / 3.0f;

        Console.WriteLine("El promig de les notes es: " + promig);
        Console.WriteLine(promig > MinNota ? "Aprovat" : "Suspès");

    }
}

