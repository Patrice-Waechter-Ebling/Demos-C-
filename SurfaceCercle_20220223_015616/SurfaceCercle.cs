/*********************************************
*
* Projet généré avec CreateurProjetsCSharp_V1.014 v:1.0.1.14
*  Module:  SurfaceCercle
* Développé par Patrice Waechter-Ebling 2022
*
 **********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SURFACECERCLE
{
    internal class Program  
{
        static void Main(string[] args)
{
            double RayonCercle = 15;

            Console.Write($"Méthode A - Surface du cercle de rayon {RayonCercle} est : ");
            double SurfaceCalculee = RayonCercle * RayonCercle * Math.PI; 
            Console.WriteLine(Math.Round(SurfaceCalculee, 2));
            Console.WriteLine("\n-----------\n");
		 Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console
		}
    }
}
