using System;

namespace DemoCadreDynamique
{
    class DemoCadreDynamique
    {
        static string Separateur(int colones)
        {
            string tmp = "+";
            for (int x = 0; x < colones; x++)
            {
                tmp += "----+"; 
            }
            return tmp;
        }
        static void Main(string[] args)
        {
            Console.Title = "DemoCadreDynamique";
            Console.WriteLine(Console.Title);
            Random rnd = new Random();
            Console.Write("Nombre de lignes? ");
            int nombreLignes = Int32.Parse(Console.ReadLine());
            Console.Write("Nombre de colones? ");
            int nombrecolones = Int32.Parse( Console.ReadLine());
            Console.WriteLine(Separateur(nombrecolones));
            for (int x = 0; x < nombreLignes; x++) 
            {
                for (int y = 0; y < nombrecolones; y++) { 
                    Console.Write($"| {rnd.Next(10,40)} ");
                }
                Console.Write("|\n");
                Console.WriteLine(Separateur(nombrecolones)); 
           } 
        }
    }
}
