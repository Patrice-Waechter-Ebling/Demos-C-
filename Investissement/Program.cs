using System;

namespace CS_Investissement
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital; double taux; double total;double nCapital;
            int nAnnees;
            Console.Title ="Calculateur de progression pour Investissement";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n     ╔══════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("     ║                                                       Programme developppe dans le cadre de l'AEC!   ║");
            Console.WriteLine("     ║                                                                                                      ║");
            Console.WriteLine("     ║                       Bienvenue au programme de calcul  d'investissment                              ║");
            Console.WriteLine("     ║                                                                                                      ║");
            Console.WriteLine("     ║                                                                                                      ║");
            Console.WriteLine("     ╚══════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Entrez le montant du capital initial");
            capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entrez le montant du taux fixe ");
            string tmp=Console.ReadLine();
            taux = Convert.ToDouble(tmp);
            total = capital + (capital * taux * 0.01);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Total de la 1ere annee " + total.ToString()+ " soit un gain de " +Convert.ToString( total - capital)+ "$");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Entrez le nombre d'annees ");
            nAnnees = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            for (int x = 1; x < nAnnees + 1; x++)            {
                nCapital = total;
                total = nCapital + (nCapital * taux * 0.01);
                Console.WriteLine( "Total de la "+ Convert.ToString( x + 1) +"e annee " +total.ToString() + " soit un gain de " +Convert.ToString( total - capital)+"$");

            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

