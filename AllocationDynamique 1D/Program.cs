using System;

namespace AllocationDynamique1D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theVecteur;

            theVecteur = new int[2];

            theVecteur[0] = 79;
            theVecteur[1] = 97;
            Console.WriteLine($"the Vecteur { GC.GetTotalAllocatedBytes(true)}");

            Console.WriteLine($"the Vecteur[0] { theVecteur[0]}");
            Console.WriteLine($"the Vecteur[1] { theVecteur[1]}");
            int a = 0;
            for (int i=0; i<theVecteur.Length; i++)
            {
                Console.WriteLine($"[{i}] = {theVecteur[i]} ");
            }
            MaBoucleFor(theVecteur);
        }
        static void MaBoucleFor(int[] Patate) 
        {
            for (int i = 0; i < Patate.Length; i++) 
            {
                Console.WriteLine(Patate[i]);
            }
        }
    }
}
