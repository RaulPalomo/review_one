using System;
using RepasGit;
class Program
{
    public static void Main()
    {
        int nota1, nota2,nota3,resposta;
        const int MinNota = 6;
        List<Ciutat> ciutats = new List<Ciutat>();
        Console.WriteLine("Introdueix la primera qualificació");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la segona qualificació: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la tercera qualificació: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        float promig = (nota1 + nota2 + nota3) / 3.0f;

        Console.WriteLine("El promig de les notes es: " + promig);
        Console.WriteLine(promig > MinNota ? "Aprovat" : "Suspès");

        do
        {
            Console.WriteLine("Escriu el nom de la ciutat");
            string ciutat = Console.ReadLine();
            Console.WriteLine("Escriu el seu CP");
            string cp = Console.ReadLine();
            ciutats.Add(new Ciutat(ciutat, cp));
            Console.WriteLine("Vols continuar? \n1.Sí 2.No");
            resposta = Convert.ToInt32(Console.ReadLine());
        }while (resposta == 1);

        foreach (var ciutat in ciutats)
        {
            Console.WriteLine(ciutat);
        }
    }
}

