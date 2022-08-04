/*********************************************
		*
* Projet genere avec CSProjectCreator v:1.01b
		*
*  Module:  Algorithme_AnneeBiextile_20220118_
* Developpe par Patrice Waechter-Ebling 2022
		*********************************************/
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	namespace Algorithme_AnneeBiextile_20220118_{	    
        internal class Program  {
	        static void Main(string[] args){
//Votre segment de code  a été inséré ici
             Console.WriteLine("Entrez 1 annee au clavier en tapant entrée");
            int nbrA = Convert.ToInt32(Math.Truncate(Convert.ToDouble(Console.ReadLine().Replace(".", ","))));
            if ( (nbrA % 400 == 0)||(nbrA % 4 == 0)&&(nbrA % 100 != 0))
                {
                    Console.WriteLine($"{nbrA} est une année bisextille");
                }
                else
                {
                    Console.WriteLine($"{nbrA} n'est pas une année bisextille");
                }
            if (DateTime.IsLeapYear(nbrA) == true) {
                Console.WriteLine($"{nbrA} est une année bisextille datetime");
            }        else
            {
                Console.WriteLine($"{nbrA} n'est pas une année bisextille datetime");
            }
		 Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la consolen		}


		 Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console
		}
    }
}
