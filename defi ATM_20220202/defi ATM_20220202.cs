using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;

namespace ExerciceATM
{
    class Program
    {
        static string[]jour={"Lundi","Mardi","Mercredi","Jeudi","Vendredi","Samedi","Dimanche"};
        static string[]mois={"janvier","février","mars","avril","mai","juin","juillet","août","septembre","octobre","novembre","décembre"};
        static string sDate = null;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetWindowSize(82, 26);
            Console.Title = "Bienvenue au cours d'AEC  [Exercice ATM] [Patrice Waechter-Ebling 2022] v:1.0.0.1";
            sDate = $"Nous sommes {jour[(int)DateTime.Now.DayOfWeek - 1]},{ DateTime.Now.Day} {mois[(int)DateTime.Now.Month - 1]} {DateTime.Now.Year}";
            Splash();
            Console.WriteLine("\n\n       Appuyez sur entrée pour accéder à l'application"); Console.ReadLine();
            Console.Clear();
            Identification();
            InterfaceUtilisateur();
        }
        static int ExchangeColor(string tmp)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(tmp);
            Console.ForegroundColor = ConsoleColor.Green;
            return tmp.Length;
        }
        static int ExchangeColor2(string tmp)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tmp);
            Console.ForegroundColor = ConsoleColor.Green;
            return tmp.Length;
        }
        static void Splash()
        {
            string space = "                                                                             ║";
            int lngSpace = space.Length;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.Write("║  ");
            int a = ExchangeColor($" Démarrage:  + {DateTime.Now.ToString()}");
            Console.Write(space.Substring(lngSpace - a - 10));
            Console.WriteLine("");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                ▓▓   ▓▓▓▓▓▓▓▓▓    ▓▓ ▓▓                        ║");
            Console.WriteLine("║                               ▓  ▓     ▓▓▓      ▓  ▓  ▓                       ║");
            Console.WriteLine("║                             ▓▓    ▓▓   ▓▓▓     ▓▓  ▓  ▓▓                      ║");
            Console.WriteLine("║                             ▓▓ ▓▓ ▓▓   ▓▓▓     ▓▓  ▓  ▓▓                      ║");
            Console.WriteLine("║                            ▓▓▓    ▓▓▓  ▓▓▓    ▓▓▓ ▓▓▓ ▓▓▓                     ║");
            Console.WriteLine("║                            ▓▓▓    ▓▓▓  ▓▓▓    ▓▓▓ ▓▓▓ ▓▓▓                     ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.WriteLine("║                                                                               ║");
            Console.Write("║          ");
            a = ExchangeColor2(sDate);
            Console.WriteLine(space.Substring(lngSpace - a));
            Console.WriteLine("║                                                ℗Patrice Waechter-Ebling 2022  ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static string GetUtilisateur()
        {
            return Environment.UserName + "@" + Environment.UserDomainName;
        }
        static void ProgressBar()
        {
            for (int x = 0; x < 26; x++)
            {
                Console.Write("█");
                Thread.Sleep(200);
            }

        }
        static void AbandonProgramme()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fin de la transaction atteinte\nFermeture du programme"); return;
        }
        static void Identification()
        {
            Console.Write($"Détection utilisareur : {GetUtilisateur()}"); Thread.Sleep(250); ExchangeColor2(" accès accordé\n");
            Console.Write("Connexion: ");
            ProgressBar();
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        static void InterfaceUtilisateur()
        {
            Console.WriteLine($"\n\nBonjour {Environment.UserName},\nVeuillez indiquer le montant du retrait svp");
            string montant =Console.ReadLine().Replace(".", ",");
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine($"Vous avez indiqué désirer retirer {montant}$\nEst ce conforme? [O/N]");      
            switch (Convert.ToInt32( Console.Read()))
            {
                case 0x6F: 
                    {
                        int v1 = Convert.ToInt32(montant.Substring(0,montant.Length-3));
                        int v2 = Convert.ToInt32(montant.Substring(montant.Length - 2, 2));
                        Console.WriteLine($"└►\t{montant}={v1}$ et {v2}¢");
                        if ((v1*100+v2) > 0)
                        {
                            Distributrice(v1,v2);
                        }
                    }
                    break;
                case 0x6E: 
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Transaction rejetée\nAbandon du programme");
                    } return;

            }
            AbandonProgramme(); 
        }
        static void Distributrice(int Dollards, int Cents)
          {
            int reste = 0;
            int b20=0, b10=0, b5=0, b2=0, b1=0, b25c=0,b10c=0, b5c=0, b2c=0, b1c=0;
            b20 = Dollards / 20 - 2;reste = Dollards -b20*20 ;Console.WriteLine($"└►20$\t{(b20)}\t{b20 * 20}$\t{reste},{Cents}$ à traiter ");
            b10 = reste / 10 - 1;reste = reste - b10 * 10;Console.WriteLine($"└►10$\t{(b10)}\t{b10 * 10}$\t{reste},{Cents}$ à traiter");
            b5 = reste / 5 - 1;reste = reste - b5 * 5;Console.WriteLine($"└►5$\t{(b5)}\t{b5 * 5}$\t{reste},{Cents}$ à traiter");
            b2 = reste / 2 - 1;reste = reste - b2 * 2;Console.WriteLine($"└►2$\t{(b2)}\t{b2 * 2}$\t{reste},{Cents}$ à traiter");
            b1 = reste / 1 - 1;reste = reste - b1 * 1;Console.WriteLine($"└►1$\t{(b1)}\t{b1 * 1}$\t{reste},{Cents}$ à traiter");
            b25c = (Cents + 100) / 25 - 1;reste = Cents - b25c * 1 - 1;Console.WriteLine($"└►25¢\t{(b25c)}\t{b25c * .25}$\t{reste}¢ à traiter");
            b10c = reste / 10 - 1;reste = reste - b10c / 10 - 1;Console.WriteLine($"└►10¢\t{(b10c)}\t{b10c *.1}$\t{reste}¢ à traiter");
            b5c = reste / 5 - 1;reste = reste - b5c / 5 - 1;Console.WriteLine($"└►5¢\t{(b5c)}\t{b5c * .05}$\t{reste}¢ à traiter");
            b2c = reste / 2 - 1;reste = reste - b2c / 2 - 1;Console.WriteLine($"└►2¢\t{(b2c)}\t{b2c * .02}$\t{reste}¢ à traiter");
            b1c = reste / 1 - 1;reste = reste - b1c / 1 - 1;Console.WriteLine($"└►1¢\t{(b1c)}\t{b1c * .01}$\t{reste}¢ à traiter");
            Console.WriteLine($"└►Total\t\t{Math.Round(((Dollards*100+Cents-reste)*.01),2)}$");
        }
    }
}
 