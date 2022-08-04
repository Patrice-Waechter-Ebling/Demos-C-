/*********************************************
		*
* Projet genere avec CSProjectCreator v:1.01b
		*
*  Module:  Algorithme_Exo_Algo2
* Developpe par Patrice Waechter-Ebling 2022
		*********************************************/
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
namespace Algorithme_Exo_Algo2
{	    
	internal class Program  
	{
	    static void Main(string[] args)
		{
			double A;
			Console.Title = "Afficher les 10 entiens suivant nímporte quelle valeur";
			Console.WriteLine(Console.Title);
			Console.Write("Entrez le  nombre : ");
			A = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine($"Sortie --->: {A + 1} {A + 2} {A + 3} {A + 4} {A + 5} {A + 6} {A + 7} {A + 8} {A + 9} {A + 10}");	
			for (int x = 1; x < 11; x++)
			{
				Console.WriteLine($"Sortie --->: {Math.Truncate(A) + x}");
			}
			Console.ReadLine();
			Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console
		}
    }
}
