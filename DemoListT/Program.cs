using System;
using System.Collections.Generic;

namespace DemoListT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> ListeDeMots = new List<string>();
            //   ListeDeMots.Add("Patate");
            //   ListeDeMots.Add("Tomate");
            do
            {
                Console.Clear();
                Console.WriteLine("Entrez un autre mot ou une phrase svp: ");
                ListeDeMots.Add(Console.ReadLine());
                Console.WriteLine("appuyez sur la touche x pour arreter ou \nune autre pour ajouter un mot");
            } while (Console.ReadKey(true).Key != ConsoleKey.X);
            Console.WriteLine("\nAffichage avec for");
            for (int i=0; i<ListeDeMots.Count; i++)
            {
            Console.WriteLine(ListeDeMots[i]);
            } 
            Console.WriteLine("\nAffichage avec foreach");
            foreach (string unMot in ListeDeMots) {
                Console.WriteLine(unMot);
                Console.WriteLine("\n===========");
                foreach (char uneLettre in unMot)
                    Console.Write(uneLettre);
                Console.WriteLine("\n===========");

            }
           
        }
    }
}