using System;

namespace Demo_Tableau1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            AllocationDynamiqueChar();
            AllocationStatiqueChar();
            AllocationStatiqueString();
            AllocationDynamiqueString();
            Console.WriteLine(" ----> Fini <-----");


            static void AllocationDynamiqueChar()
            {
                Console.WriteLine("\nAllocationDynamiqueChar");
                char[] PatateA;
                PatateA = new char[6];
                PatateA[0] = 'a';
                PatateA[1] = (char)79;
                PatateA[2] = 'b';
                PatateA[3] = '+';

                for (int i = 0; i < PatateA.Length; i++)
                {
                    Console.WriteLine($"Position :{i} Contenu: {PatateA[i]}");
                }
            }
            static void AllocationStatiqueChar()
            {
                 Console.WriteLine("\nAllocationStatiqueChar");
                char[] PatateA = { 'a', (char)79, 'b', '+', ' ' };

                for (int i = 0; i < PatateA.Length; i++)
                {
                    Console.WriteLine($"Position :{i} Contenu: {PatateA[i]}");
                }
            }
            static void AllocationDynamiqueString()
            {
                Console.WriteLine("\nAllocationDynamiqueString");
                string[] TomateB =new string[6];                
                TomateB[0] = "Un";
                TomateB[1] ="nombre";
                TomateB[2] ="entier";
                TomateB[3] = "79";

                for (int i = 0; i < TomateB.Length; i++)
                {
                    Console.WriteLine($"Position :{i} Contenu: {TomateB[i]}");
                }
                for (int i=0; i<TomateB[1].Length; i++)
                {
                    // if(i!=3)
                    Console.WriteLine($"{TomateB[1][i]} - ");
                }
                Console.WriteLine($"En Majuscules {TomateB[1].ToUpper()} - ");
                Console.WriteLine($"En majuscules (1char) {(char)(TomateB[1][0]-32)} - ");
                if (TomateB[1][0]>96 && TomateB[1][0]<123)
                {
                    Console.WriteLine((char)(TomateB[1][0] - 32));
                }
                else {
                    Console.WriteLine(TomateB[1][0]);
                }
            }
            static void AllocationStatiqueString()
            {
                Console.WriteLine("\nAllocationStatiqueString");
                string[] TomateB = { "La", "tomate", "n\'est", "pas", "un", "legume"," ","!"};

                for (int i = 0; i < TomateB.Length; i++)
                {
                    Console.WriteLine($"Position :{i} Contenu: {TomateB[i]}");
                }
            }
        }
    }
}
