using System.Collections.Generic;
using System;

namespace Laboratoire4
{
    internal class Plats
    {
        string NomDuPlat;
        int numero;
        List<Plats> pl=new List<Plats>(20);

        public Plats(string nomDuPlat, int numero)
        {
            this.NomDuPlat = nomDuPlat;
            this.numero = numero;
        }

        public Plats()
        {
        }
        public void ListerPlats()
        {
            for (int x=0; x<pl.Count; x++)
            {
                Console.WriteLine($"{pl[x].numero}: {pl[x].NomDuPlat}");
            }
        }
        public Plats GetPlat(int choix) { 
            return pl[choix]; }
        public int CreerListePlats(string nom, int numero) {
            this.NomDuPlat = nom;
            this.numero = numero;
            pl.Add(this);
            return pl.Count;
        }
    }
}