using System;

namespace FormuleQuadratique
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Projet d'application visant a utiliser la formule quadratique\nEntrez la  valeur de a (les x²)");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entrez la  valeur de a (les x)" );
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entrez la  valeur de la constante");
            c = Convert.ToDouble(Console.ReadLine());
            d =( -b + Math.Sqrt((b * b) - 4*a*c)) / (2 * a);
            Console.Write($"x1= {d}\n");
            d = (-b-Math.Sqrt((b * b) - 4 * a * c)) /( 2 * a);
            Console.Write($"x2={d}\n");
        }
    }
}
