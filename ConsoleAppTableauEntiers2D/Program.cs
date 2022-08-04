using System;

namespace ConsoleAppTableauEntiers2D
{
    internal class Program_TableauEntiers2D
    {
        static int [][] tableau;
       static void Main(string[] args)
        {
            Console.WriteLine(">> DÉBUT PROGRAMME - TABLEAU 2D <<");
            Console.Write("Entrez nombre de lignes voulues svp : ");
            int lignes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez nombre de colonnes voulues svp : ");
            int colonnes = Convert.ToInt32(Console.ReadLine());
	        CreerTableau(lignes, colonnes);
            Menu(tableau,  lignes,  colonnes);
            Console.WriteLine();
       }
       static void CreerTableau( int lignes, int Colones)
        { 
            tableau = new int[lignes][];
              for (int i = 0; i < lignes; i++)
            { 
                tableau[i] = new int[Colones];
            }
            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < tableau[i].Length; j++)
                    tableau[i][j] = i + j;
            }
            Menu(tableau, lignes, Colones);
        }
        static void Menu(int[][] Tableau, int lignes, int Colones)
        {
            Console.WriteLine("Choisissez parmi les options suivantes : ");
            Console.WriteLine("(1) Remplissage manuel");
            Console.WriteLine("(2) Remplissage automatique");
            Console.WriteLine("(3) Affichage tel que créé");
            Console.WriteLine("(4) Affichage Lignes <-> Colonnes");
            Console.WriteLine("(5) Affichage avec valeurs doublées");
            Console.WriteLine("(6) Affichage tel que créé");
            Console.WriteLine("(Q) Quitter le programme");
            Console.Write("Votre choix ?");

            ConsoleKey choix = Console.ReadKey(true).Key;
            if (choix == ConsoleKey.D1 || choix == ConsoleKey.NumPad1)
            {
                Console.Write(" 1");
                tableau=RemplirTableau2Dmanuellement();
            }
            else if (choix == ConsoleKey.D2 || choix == ConsoleKey.NumPad2) 
            { 
                Console.Write(" 2");
            tableau = RemplissageAutomatique(lignes, Colones); // tableau = sert a mettre a jour le tableau
            }
            else if (choix == ConsoleKey.D3 || choix == ConsoleKey.NumPad3)
            {
                Console.Write(" 3");
                AfficherTableau2DtelQueCree(tableau);
            }
            else if (choix == ConsoleKey.D4 || choix == ConsoleKey.NumPad4)
                Console.Write(" 4");
            //AffichageLignesColonnes();
            else if (choix == ConsoleKey.D5 || choix == ConsoleKey.NumPad5)
                Console.Write(" 5");
            //AffichageValeursDoublees();
            else if (choix == ConsoleKey.D6 || choix == ConsoleKey.NumPad6)
                Console.Write(" 6");
            //AffichageTelQueCree();
            else if (choix == ConsoleKey.Q)
                Environment.Exit(0);
            else
                Console.WriteLine("Vous devez entrer 1, 2, 3, 4, 5, 6 ou Q.");
}
        static int[][] RemplissageAutomatique(int lignes,int colones)
        {
            Console.WriteLine($"\n> RemplirTableau2DAutomatiquement({lignes},{colones})");
            System.Random random = new System.Random(); 
            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colones; j++)
                {
                    tableau[i][j] = ((int)random.Next(10, 40));
                }
            }
            AfficherTableau2DtelQueCree(tableau);
            return tableau;
        }
        static int[][] RemplirTableau2Dmanuellement()
        {
            Console.WriteLine();
            Console.WriteLine("> RemplirTableau2Dmanuellement()");
            Console.WriteLine("[IMPORTANT] : Entrez une valeur entre 10 et 40(incluant 10 et 40)");
            for (int i = 0; i < tableau.Length; i++)
            {
                for (int j = 0; j < tableau[i].Length; j++)
                {
                    Console.Write($"Tableau2d[{i}][{j}] = ");
                    int entree = Convert.ToInt32(Console.ReadLine());
                    if (entree < 10 || entree > 40)
                    { 
			Console.WriteLine(" -- Entrée invalide --");
                        j--;
                    }
                }
            }
            return tableau;
            
                    
        }
        static void AfficherTableau2DtelQueCree(int[][] TableauEntiers2D)
        {
            Console.WriteLine("\n> AfficherTableau2DtelQueCree() : ");

            for (int i = 0; i < TableauEntiers2D.Length; i++)
            {
                for (int j = 0; j < TableauEntiers2D[i].Length; j++)
                    Console.Write($"{TableauEntiers2D[i][j]} ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
