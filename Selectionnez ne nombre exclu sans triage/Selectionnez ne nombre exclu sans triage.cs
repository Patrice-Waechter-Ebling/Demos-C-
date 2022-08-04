using System;

namespace Selectionnez_ne_nombre_exclu_sans_triage
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Bienvenue au cours d AEC";
            int a, b, c;
            Console.ForegroundColor = ConsoleColor.Cyan| ConsoleColor.DarkGray;           
            Console.WriteLine("Bon matin Patrice!\n\tBienvenue au cours d AEC \n\nEntrez le chiffre de depart ");
            a =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Selectionnez ne nombre exclu ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < a; x++) { if (x != b) { if ((x % 2) == 0) Console.Write(x.ToString()); Console.Write(" est une nombre pair\n"); } }
         }
    }
}
