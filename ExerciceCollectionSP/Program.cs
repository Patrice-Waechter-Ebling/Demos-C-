using System;
using System.Collections;

namespace ExerciceCollectionSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Question1();
            Question2();
        }
        static void Question1()
        {
            Item pile = new ;
            pile.Push(new Item("cellerie", 2,2.25));
            pile.Push(new Item("Pates", 1,1.02));
            pile.Push(new Item("salade", 1,1.08));
            Console.WriteLine($"Il y a {pile.Count} articles dans la boite");
            while (true)
            {
                try
                {
                    Item i = (Item)pile.Pop();
                    Console.WriteLine("Supression de "+i.GetNom()+" "+i.GetQuantitee()+" "+i.GetPrix());
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }
        static void Question2()
        {
            Queue fileAttente = new Queue();
            fileAttente.Enqueue(new Clients(1));
            fileAttente.Enqueue(new Clients(2));
            fileAttente.Enqueue(new Clients(3));
            fileAttente.Enqueue(new Clients(4));
            Console.WriteLine($"Il y a {fileAttente.Count} clients dans la fille");
            while (true)
            {
                try
                {
                    Clients c = (Clients)fileAttente.Dequeue();
                    Console.WriteLine("Il reste " +fileAttente.Count + " clients en attente");
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}
