using System;
using System.Collections.Generic;
using System.Text;

namespace BeauCamion
{
    static class Pizzeria
    {
        static string NomPizza= "Margarita Maths";
        static int NombrePizza=1;
        static double prix=4.29;
        static bool sauce = false;

        public static Int32 GetNombrePizza() { return NombrePizza; }
        public static void SetNombrePizza(int pizza) {  NombrePizza=pizza; }

        public static String GetNomPizza() { return NomPizza; }

        public static bool AjouterDeLaSauce(string typeDeSauce) {
            if (typeDeSauce == "sauce poutine") sauce= true;
            return sauce;
        }

       public  static string Commander(string NomPizza, int Quantite,bool sauce) 
        {
            return "Votre Commande: " + Quantite.ToString() + " " + NomPizza + " Suplement sauce :" + sauce.ToString() + " revient a " + Math.Round(Quantite * prix, 2) + "$";
        }
    }
}
