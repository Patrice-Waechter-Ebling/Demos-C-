using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationHeritage
{
    class Homme
    {
        int taille;
        string nom;
        string prenom;
        int age;
        double couleur;

        public Homme(double couleur, int age = 0, string prenom = null, string nom = null, int taille = 0)
        {
            this.couleur = couleur;
            this.age = age;
            this.prenom = prenom;
            this.nom = nom;
            this.taille = taille;
        }
    }
}
