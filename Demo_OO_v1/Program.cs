using System;

namespace Demo_OO_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile uneAuto = new Automobile();
            Console.WriteLine($"uneAuto.NbrPlaces : {uneAuto.NbrPlaces}");
            Console.WriteLine($"uneAuto.NbrPassagerPresents : {uneAuto.NbrPassagerPresents}");
            for (int i = 0; i < 8; i++) {
                Console.WriteLine("Ajout de passager ");
                if (uneAuto.AjouterPassager() == false)
                { 
                    Console.WriteLine("Il n'y a plus de place. envoyer un autre vehicule svp");
                }
                Console.WriteLine($"uneAuto.NbrPassagerPresents : {uneAuto.NbrPassagerPresents}");
            }
            Automobile uneAutreAuto = new Automobile();
            Console.WriteLine($"uneAutreAuto.NbrPlaces : {uneAutreAuto.NbrPlaces}");
            Console.WriteLine($"uneAutreAuto.NbrPassagerPresents : {uneAutreAuto.NbrPassagerPresents}");
            int[] config = { 5, 2 };
            Automobile uneAutreAuto2 = new Automobile(config);
            Console.WriteLine($"uneAutreAuto2.NbrPlaces : {uneAutreAuto2.NbrPlaces}");
            Console.WriteLine($"uneAutreAuto2.NbrPassagerPresents : {uneAutreAuto2.NbrPassagerPresents}");

        }
    }
}
