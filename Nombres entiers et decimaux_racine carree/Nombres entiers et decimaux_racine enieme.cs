using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace RacineEnieme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bienvenue au cours d AEC\nRacine Carrées";
            Console.ForegroundColor = ConsoleColor.Cyan | ConsoleColor.DarkGray;
            Console.WriteLine("\n\nEntrez le radical ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entrez le facteur N ");
            double y = Convert.ToDouble(Console.ReadLine());
            double b = System.Math.Pow(x, 1 / y);
            Console.WriteLine("La racine enieme " + y +" de " + x + " est: " + b);
            Console.ReadLine();
        }
    }
}
