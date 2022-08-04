using System;
using System.IO;

namespace DateEtHeure2
{
    internal class Program
    {
        static public string[] jours = {"Lundi","Mardi","Mercredi","Jeudi","Vendredi","Samedi","Dimanche" };
        static public string[] mois = {"janvier","février","mars","avril","mai","juin","juillet","aout","septembre","octobre","novembre","décembre" };
        static void Main(string[] args)
        {
            Console.Title = "Bienvenue au cours d AEC";
            Console.ForegroundColor = ConsoleColor.Cyan | ConsoleColor.DarkGray;
            Console.WriteLine($"{Console.Title}\nFait le {DateTime.Now} ");
            Console.WriteLine($"Nous sommes {jours[(int)DateTime.Now.DayOfWeek-1]},le {DateTime.Now.Day} {mois[(int)DateTime.Now.Month - 1]} {DateTime.Now.Year}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
