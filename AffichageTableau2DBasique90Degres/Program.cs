using System;

namespace AffichageTableau2DBasique90Degres__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AffichageTableau2DBasique90Degres__";
            Console.WriteLine(Console.Title);
            Console.Write("Entrez le nombre de lignes voulues svp : ");
            int lignes= Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le nombre de colones voulues svp : ");
            int colones = Convert.ToInt32(Console.ReadLine());
            CreeTableau2D(colones, lignes);
        }
        static void CreeTableau2D(int colonnes,int lignes)
        {
            int[][] Tableau2D = new int[lignes][];
            for (int i = 0; i < lignes; i++)
            {
                Tableau2D[i] = new int[colonnes];
            }
            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                    Tableau2D[i][j] = i + j;
            }
            for (int i = 0; i < Tableau2D.Length; i++)
            {
                for (int j = 0; j < Tableau2D[i].Length; j++) { }
            }
            Basique90Degres(colonnes, lignes);
        }
        static void Basique90Degres(int colonnes,int lignes)
        {
            int[][] Tableau2D = new int[colonnes][];
            for (int i = 0; i < 3; i++)
            {
                Tableau2D[i] = new int[lignes];
            }
            Console.WriteLine(Tableau2D.Length);
            Console.WriteLine(Tableau2D[0].Length);
            for (int i = 0; i < Tableau2D.Length; i++)
            {
                for (int j = 0; j < Tableau2D[i].Length; j++)
                    Tableau2D[i][j] = i + j;
            }
            for (int i = 0; i < Tableau2D.Length; i++)
            {
                for (int j = 0; j < Tableau2D[i].Length; j++)
                    Console.Write($"{Tableau2D[i][j]} ");
                Console.WriteLine();
            }

        }

    }
}
