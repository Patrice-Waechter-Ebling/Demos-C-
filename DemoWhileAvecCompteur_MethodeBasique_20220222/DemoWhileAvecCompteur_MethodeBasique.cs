/*********************************************
*
* Projet généré avec CreateurProjetsCSharp v:1.0.1.3
*  Module:  DemoWhileAvecCompteur_MethodeBasique
* Développé par Patrice Waechter-Ebling 2022
*
 **********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DEMOWHILEAVECCOMPTEUR_METHODEBASIQUE{    internal class Program  {
        static void Main(string[] args){
           int i = 0;
            while (i < 5)
            {
                Console.WriteLine("<--[DÉBUT] Tour de boucle -->");
                Console.WriteLine(i);

                i++;

                if (i == 5)
                {
                    Console.WriteLine(i);
                }
                //Même chose que : if (i == 5) { Console.WriteLine(i); }

                Console.WriteLine("<--[FIN] Tour de boucle -->");
            }
		 Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console
		}
    }
}
