using System;
using System.Collections.Generic;

namespace ExercicesCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<LocalDeClasse> lc = new List<LocalDeClasse>();
            List<Etudiant> et = new List<Etudiant>();
            List<Enseignant> en = new List<Enseignant>();
            LocalDeClasse classe = new LocalDeClasse(102, "POO");
            lc.Add(classe);
            Console.WriteLine($"La salle {classe.GetID()} a ete attribuee au cours {classe.GetNom()}");
            Enseignant enseignant = new Enseignant(21, "Philipe");
            en.Add(enseignant);
            Console.WriteLine($"L'enseignant attribue au cours sera {enseignant.GetNom()}");
            et.Add(new Etudiant(15521, "Toto"));
            et.Add(new Etudiant(24441, "T58to"));
            et.Add(new Etudiant(21414, "98to"));
            et.Sort();
            foreach(Etudiant e in et)
            {
                Console.WriteLine($"{e.GetID()}: {e.GetNom()}");
            }
        }
    }
}
