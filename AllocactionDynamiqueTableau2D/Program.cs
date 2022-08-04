using System;

namespace AllocactionDynamiqueTableau2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] theMatrix;
            theMatrix = new int[2][];
            for (int i = 0; i < 2; i++)
                theMatrix[i] = new int[3];
            /*
             * j' utiliswe un for() pour allouer
             * les ressources a chaque vercteur
             * au lieu d' 'ecrire:
             * theMatrix[0] = new int[3];
             * theMatrix[1] = new int[3];
            
             */

            Console.WriteLine("Hello World!");
        }
    }
}
