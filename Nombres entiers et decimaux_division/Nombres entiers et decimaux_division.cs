/***************************
 * Lire et ecrire la console
 ***************************/
using System;

namespace Nombres_entiers_et_decimaux_division
{
    class Program
    {

        static void Main(string[] args) //Nombres entiers et decimaux 
        {
            Console.Title = "Bienvenue au cours d AEC";
             Console.ForegroundColor = ConsoleColor.Cyan| ConsoleColor.DarkGray;           
            Console.WriteLine("\n\nEntrez le premier chiffre ");
            double a =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Entrez le deuxieme chiffre ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Le reste des deux chiffres est de "+Convert.ToString(a-b));
        }
    }
}
