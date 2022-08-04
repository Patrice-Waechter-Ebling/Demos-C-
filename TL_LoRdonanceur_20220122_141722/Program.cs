/*********************************************
		*
* Projet genere avec CSProjectCreator v:1.01b
		*
*  Module:  TL_LoRdonanceur_20220122_141722
* Developpe par Patrice Waechter-Ebling 2022
		*********************************************/
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	namespace TL_LoRdonanceur_20220122_141722{	    internal class Program  {
	        static void Main(string[] args){
//Votre segment de code  a été inséré ici
            Console.WriteLine("==> LeComparateur");
            Console.WriteLine("Entrez 2 nombres au clavier en tapant entrre entre chacun");
            Console.Write("Nombre A: ");
            decimal nbrA = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nombre B: ");
            decimal nbrB = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------");
            if (nbrA > nbrB)
            {
                Console.WriteLine($"{nbrA} est plus grand que {nbrB} ");
            }
            else
            {
                if (nbrA < nbrB)
                {
                    Console.WriteLine($"{nbrA} est plus petit que {nbrB} ");
                }
                else
                {
                    Console.WriteLine($"{nbrA} est egale e {nbrB} ");
                }
            }
		 Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la consolen		}

		 Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console
		}
    }
}
