using System;

namespace ConsoleTravailString
{
    class Program
    {

         static void Main(string[] args)  { 
            string jour, mois;
            Console.Title = "Bienvenue au cours d AEC";
            Console.ForegroundColor = ConsoleColor.Cyan | ConsoleColor.DarkGray;
            Console.WriteLine("Fait le : " + DateTime.Now.ToString());
            switch ((int)DateTime.Now.DayOfWeek-1){
                case 0: jour="Lundi ";break;
                case 1: jour="Mardi "; break;
                case 2: jour="Mercredi "; break;
                case 3: jour="Jeudi "; break;
                case 4: jour="Vendredi "; break;
                case 5: jour="Samedi "; break;
                case 6: jour="Dimanche "; break;
            }
            switch ((int)DateTime.Now.Month - 1)            {
                case 0: mois = "janvier "; break;
                case 1: mois = "fevrier "; break;
                case 2: mois = "mars "; break;
                case 3: mois = "avril "; break;
                case 4: mois = "mai "; break;
                case 5: mois = "juin "; break;
                case 6: mois = "juillet "; break;
                case 7: mois = "aout "; break;
                case 8: mois = "septembre "; break;
                case 9: mois = "octobre "; break;
                case 10: mois = "novembre "; break;
                case 11: mois = "decembre "; break;
            Console.WriteLine("Nous sommes " + jour + DateTime.Now.Day + " " + mois + DateTime.Now.Year);
             string tmp = Console.ReadLine();//Garde la fenetre ouverte une fois rendue  à la fin des instruction jusqu'as ce qu'on presse entrée

            }
        }
    }
}
