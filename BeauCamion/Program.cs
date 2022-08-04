using System;

namespace BeauCamion
{
    class Program
    {
         static void Main(string[] args)
        {
            BeauCamion c1 = new BeauCamion("Chez Patirce","");

            Console.WriteLine("Bonjour et bienvenu a " + c1.GetNom());
            Console.WriteLine("Voiture n: " + c1.GetCompteur());
            Console.WriteLine(Pizzeria.Commander(Pizzeria.GetNomPizza(), 5, Pizzeria.AjouterDeLaSauce("piquante")));
            BeauCamion c2 = new BeauCamion("Ford","vert");
            Console.WriteLine("Bonjour et bienvenu a " + c2.GetNom());
            Console.WriteLine("Voiture n: " + c2.GetCompteur());
            Console.WriteLine(Pizzeria.Commander(Pizzeria.GetNomPizza(), 5, Pizzeria.AjouterDeLaSauce("piquante")));
        }
    }
}
